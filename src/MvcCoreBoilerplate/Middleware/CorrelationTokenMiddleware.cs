using Microsoft.AspNetCore.Http;
using Serilog.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Middleware
{
    public class CorrelationTokenMiddleware
    {
        private readonly RequestDelegate next;

        public CorrelationTokenMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Guid correlationToken;
            if (!(!string.IsNullOrEmpty(httpContext.Request.Headers["Correlation-Token"].FirstOrDefault()) 
                && Guid.TryParse(httpContext.Request.Headers["Correlation-Token"].FirstOrDefault(), out correlationToken)))
            {
                correlationToken = Guid.NewGuid();
            }

            httpContext.Items.Add("correlationToken", correlationToken.ToString());
            using (LogContext.PushProperty("CorrelationToken", correlationToken))
            {
                await next(httpContext);
            }
        }
    }
}
