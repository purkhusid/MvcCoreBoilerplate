﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using MvcCoreBoilerplate.Queries;
using MvcCoreBoilerplate.Queries.GetOrder;

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

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            return await mediator.Send(new GetOrderQuery { Id = id });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
