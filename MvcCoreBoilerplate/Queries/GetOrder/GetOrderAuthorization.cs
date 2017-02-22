using MvcCoreBoilerplate.Exceptions;
using MvcCoreBoilerplate.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Queries.GetOrder
{
    public class GetOrderAuthorization : IAuthorizationValidator<GetOrderQuery>
    {
        public void Authorize(GetOrderQuery request)
        {
            //Check if user has access to this order etc
            if(request.Id == 3 || request.Id == 0)
            {
                throw new UnauthorizedException("User does not have access to this order");
            }
        }
    }
}
