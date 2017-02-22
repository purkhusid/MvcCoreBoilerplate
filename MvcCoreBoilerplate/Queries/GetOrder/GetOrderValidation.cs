using MvcCoreBoilerplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidation;

namespace MvcCoreBoilerplate.Queries.GetOrder
{
    public class GetOrderValidator : AbstractValidator<GetOrderQuery>
    {
        public GetOrderValidator()
        {
            RuleFor(request => request.Id).NotEqual(0);
        }
    }

    public class GetOrderValidation : IRequestValidator<GetOrderQuery>
    {
        public IEnumerable<ValidationFailure> Validate(GetOrderQuery request)
        {
            var validator = new GetOrderValidator();

            return validator.Validate(request).Errors;
        }
    }
}
