using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.Commands.SubmitOrder
{
    public class SubmitOrderCommandHandler : IRequestHandler<SubmitOrderCommand>
    {
        public void Handle(SubmitOrderCommand message)
        {
            Console.WriteLine("LAFF");
        }
    }
}
