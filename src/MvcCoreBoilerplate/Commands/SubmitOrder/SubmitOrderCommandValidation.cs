using MvcCoreBoilerplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidation;

namespace MvcCoreBoilerplate.Commands.SubmitOrder
{
    public class SubmitOrderCommandValidator : AbstractValidator<SubmitOrderCommand>
    {
        public SubmitOrderCommandValidator()
        {
            RuleFor(request => request.Description).NotNull();
            RuleFor(request => request.Total).NotEqual(0);
        }
    }

    public class SubmitOrderCommandValidation : IRequestValidator<SubmitOrderCommand>
    {
        public IEnumerable<ValidationFailure> Validate(SubmitOrderCommand request)
        {
            var validator = new SubmitOrderCommandValidator();

            return validator.Validate(request).Errors;
        }
    }
}
