using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MiddlewareController.Middlewars
{
    public class HelloMiddleware
    {
        RequestDelegate _next;

        public  HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpcontext) {
            //custom operasyon...

            Console.WriteLine("ceyda");
            await _next.Invoke(httpcontext);
            Console.WriteLine(" ");

        }
    }
}
