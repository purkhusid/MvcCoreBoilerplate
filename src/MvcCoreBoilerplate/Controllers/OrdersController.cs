using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using MvcCoreBoilerplate.Queries;
using MvcCoreBoilerplate.Queries.GetOrder;
using MvcCoreBoilerplate.DTO;
using MvcCoreBoilerplate.Commands.SubmitOrder;

namespace MvcCoreBoilerplate.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private IMediator mediator;

        public OrdersController(IMediator mediator)
        {
            this.mediator = mediator ?? throw new ArgumentNullException("mediator");
        }

        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            return await mediator.Send(new GetOrderQuery { Id = id });
        }

        // POST api/values
        [HttpPost]
        public async void Post(SubmitOrderDTO orderDTO)
        {
            await mediator.Send(new SubmitOrderCommand { Total = orderDTO.Total, Description = orderDTO.Description });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
