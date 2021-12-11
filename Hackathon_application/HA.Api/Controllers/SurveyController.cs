﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails;
using HA.Application.Features.Surveys.First.Queries.TakeFakeSurveyFirst;
using HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails;
using HA.Application.Features.Surveys.Second.Queries.TakeFakeSurveySecond;
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
        
        [HttpGet("firstDetails/{id}", Name = "GetFirstSurveyDetails")]
        public async Task<ActionResult<FirstSurveyDetailsVm>>GetFirstSurveyDetailsById(Guid id)
        {
            var query = new GetFirstSurveyDetailsQuery() {FirstSurveyId = id};
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("secondDetails/{id}", Name = "GetSecondSurveyDetails")]
        public async Task<ActionResult<SecondSurveyDetailsVm>> GetSecondSurveyDetailsById(Guid id)
        {
            var query = new GetFirstSurveyDetailsQuery() {FirstSurveyId = id};
            return Ok(await _mediator.Send(query));
        } 

        [HttpGet("takeFakeSurveys/{id}")]
        public async Task<ActionResult<FakeSurveyFirstVm>> TakeFakeSurveyFirst(Guid id)
        {
            var queryFirst = new TakeFakeSurveyFirstQuery() { ZoneId = id };
            await _mediator.Send(queryFirst);
            var querySecond = new TakeFakeSurveySecondQuery() { ZoneId = id };
            await _mediator.Send(querySecond);
            return Ok();
        }
        /*
        [HttpGet("takeFakeSurveySecond/{id}")]
        public async Task<ActionResult<FakeSurveyFirstVm>> TakeFakeSurveySecond(Guid id)
        {
            var query = new TakeFakeSurveySecondQuery() { ZoneId = id };
            return Ok(await _mediator.Send(query));
        } */
    }
}
