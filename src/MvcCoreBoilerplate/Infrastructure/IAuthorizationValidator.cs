using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Infrastructure
{
    public interface IAuthorizationValidator<in T>
    {
        void Authorize(T request);
    }
}
