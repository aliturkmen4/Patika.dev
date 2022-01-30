using Application.CustomMiddleware.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Application.CustomMiddleware.Middlewares
{
    public class ClientConfigurationMiddleware
    {
        private readonly RequestDelegate _next;

        public ClientConfigurationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IClientConfiguration clientConfiguration)
        {
            if (httpContext.Request.Headers.TryGetValue("CLIENTNAME", out StringValues clientName))
            {
                clientConfiguration.ClientName = clientName.SingleOrDefault();
            }
            else
            {            
            }

            clientConfiguration.InvokedDateTime = DateTime.UtcNow;

            await _next.Invoke(httpContext);
        }
    }
}