using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails;
using HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace HA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SurveyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SurveyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("details/{id}", Name = "GetFirstSurveyDetails")]
        public async Task<ActionResult<FirstSurveyDetailsVm>>GetFirstSurveyDetailsById(Guid id)
        {
            var query = new GetFirstSurveyDetailsQuery() {FirstSurveyId = id};
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("details/{id}", Name = "GetSecondSurveyDetails")]
        public async Task<ActionResult<SecondSurveyDetailsVm>> GetSecondSurveyDetailsById(Guid id)
        {
            var query = new GetFirstSurveyDetailsQuery() {FirstSurveyId = id};
            return Ok(await _mediator.Send(query));
        }
    }
}
