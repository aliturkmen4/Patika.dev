using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading.Tasks;

namespace Application.CustomMiddleware.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public LoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<LoggerMiddleware>();
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {         
            using (var reader = new StreamReader(httpContext.Request.Body))
            {
                var requestBody = reader.ReadToEnd();
                
                _logger.LogInformation(requestBody);
            }

            await _next.Invoke(httpContext);
        }
    }
}