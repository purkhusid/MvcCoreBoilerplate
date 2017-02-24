using Autofac;
using MediatR;
using MvcCoreBoilerplate.Commands.SubmitOrder;
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
            //GetOrder
            builder.RegisterType<GetOrderValidation>().As<IRequestValidator<GetOrderQuery>>();
            builder.RegisterType<GetOrderAuthorization>().As<IAuthorizationValidator<GetOrderQuery>>();

            //SubmitOrder
            builder.RegisterType<SubmitOrderCommandValidation>().As<IRequestValidator<SubmitOrderCommand>>();
            builder.RegisterType<SubmitOrderCommandAuthorization>().As<IAuthorizationValidator<SubmitOrderCommand>>();

            //Behaviors
            builder.RegisterGeneric(typeof(FluentValidationBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(AuthorizationBehavior<,>)).As(typeof(IPipelineBehavior<,>));

            
            
        }
    }
}
