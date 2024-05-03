using Microsoft.AspNetCore.Builder;
using MiddlewareController.Middlewars;
using System.Runtime.CompilerServices;

namespace MiddlewareController.Extensions
{
    public class Extensions
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
