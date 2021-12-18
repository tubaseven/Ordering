using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopiOrderingApp.Application.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopiOrderingApp.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllOrdersQuery();
            return Ok(await mediator.Send(query));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetOrderByIdQuery() {   Id = id };
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateOrdersCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
