using ImageMagick;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace _40_CustomRoute.Handler
{
    public class ImageHandler
    { 
        public RequestDelegate Handler(string filePath)
        {
            return async c =>
            {
                FileInfo fileInfo = new FileInfo($"{ filePath}\\{c.Request.RouteValues["imageName"]}");
                //Hangi dizinde hangi imagei aradığımızı requeste bildirmiş olduk.

                using MagickImage magick = new MagickImage(fileInfo);//resim boyutunu ayarlar.

                int width=magick.Width, height=magick.Height;

                if (!string.IsNullOrEmpty(c.Request.Query["w"].ToString()))
                    width = int.Parse(c.Request.Query["w"].ToString());

                if (!string.IsNullOrEmpty(c.Request.Query["h"].ToString()))
                    height = int.Parse(c.Request.Query["h"].ToString());
                
                magick.Resize(width, height);

                var buffer = magick.ToByteArray();

                c.Response.Clear();
                c.Response.ContentType = string.Concat("image/", fileInfo.Extension.Replace(".", " "));
                

              //  await c.Response.WriteAsync(buffer,0,buffer.Length).ToString();
                await c.Response.WriteAsync(filePath);
                
                
                };
        }

    }
}
