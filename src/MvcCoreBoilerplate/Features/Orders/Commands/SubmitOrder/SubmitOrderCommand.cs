using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MvcCoreBoilerplate.Commands.SubmitOrder
{
    public class SubmitOrderCommand : IRequest
    {
        public string Description { get; set; }
        public decimal Total { get; set; }
    }
}
