using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers;
using HA.Application.Features.Zone.Queries.GetAllZones;
using MediatR;

namespace HA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MultiplierController : ControllerBase
    {

        private readonly IMediator _mediator;

        public MultiplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllMultipliers")]
        public async Task<ActionResult<List<MultiplierListVm>>> GetAllMultipliers()
        {
            var dtos = await _mediator.Send(new GetAllMultipliersQuery());
            return Ok(dtos);
        }
    }
}
