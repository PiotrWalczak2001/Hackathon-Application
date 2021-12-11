using HA.Application.Features.Zone.Queries.GetAllZones;
using HA.Application.Features.Zone.Queries.GetZoneById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZoneController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ZoneController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllZones")]
        public async Task<ActionResult<List<ZoneListVm>>> GetAllZones()
        {
            var dtos = await _mediator.Send(new GetAllZonesQuery());
            return Ok(dtos);
        }

        [HttpGet("details/{id}", Name = "GetZoneDetails")]
        public async Task<ActionResult<ZoneDetailsVm>> GetZoneById(Guid id)
        {
            var query = new GetZoneByIdQuery() { ZoneId = id };
            return Ok(await _mediator.Send(query));
        }

    }
}
