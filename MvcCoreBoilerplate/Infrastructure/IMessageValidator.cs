using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Infrastructure
{
    public interface IMessageValidator<in T>
    {
        IEnumerable<ValidationFailure> Validate(T request);
    }
}
