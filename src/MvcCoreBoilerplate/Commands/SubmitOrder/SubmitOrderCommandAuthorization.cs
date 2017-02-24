using MvcCoreBoilerplate.Exceptions;
using MvcCoreBoilerplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Commands.SubmitOrder
{
    public class SubmitOrderCommandAuthorization : IAuthorizationValidator<SubmitOrderCommand>
    {
        public void Authorize(SubmitOrderCommand request)
        {
            //Check if user can submit and order
            
        }
    }
}
