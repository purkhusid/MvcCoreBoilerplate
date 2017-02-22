using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace MvcCoreBoilerplate.Infrastructure.MediatR
{
    public class AuthorizationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private IAuthorizationValidator<TRequest> authorizer;

        public AuthorizationBehavior(IAuthorizationValidator<TRequest> authorizer)
        {
            this.authorizer = authorizer;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next)
        {
            authorizer.Authorize(request);

            return await next();
        }
    }
}
