using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyAspNetCore.Middlewares
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate _requestDelegate;
        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString() == "/yavuz")
                //Eğer benim contextin içindeki requstim yani pathim yavuz a eşit ise
                await context.Response.WriteAsync("Hosgeldin Yavuz");
            // bunu yaz
            else
            await _requestDelegate.Invoke(context);
        }
    }
}
