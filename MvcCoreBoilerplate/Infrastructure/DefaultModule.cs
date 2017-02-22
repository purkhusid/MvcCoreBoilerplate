using Autofac;
using MediatR;
using MvcCoreBoilerplate.Infrastructure.MediatR;
using MvcCoreBoilerplate.Queries.GetOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Infrastructure
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GetOrderValidation>().As<IMessageValidator<GetOrderQuery>>();
            builder.RegisterGeneric(typeof(FluentValidationBehavior <,>)).As(typeof(IPipelineBehavior<,>));
        }
    }
}
