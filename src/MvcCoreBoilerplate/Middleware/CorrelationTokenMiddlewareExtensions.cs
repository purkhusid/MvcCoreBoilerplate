using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Middleware
{
    public static class CorrelationTokenMiddlewareExtensions
    {
        public static IApplicationBuilder UseCorrelationToken(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CorrelationTokenMiddleware>();
        }
    }
}
