using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MvcCoreBoilerplate.Queries.GetOrder
{
    public class GetOrderQuery : IRequest<string>
    {
        public int Id { get; set; }
    }
}
