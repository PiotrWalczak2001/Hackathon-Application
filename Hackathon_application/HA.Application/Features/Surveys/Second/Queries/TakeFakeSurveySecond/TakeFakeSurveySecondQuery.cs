using MediatR;
using System;

namespace HA.Application.Features.Surveys.Second.Queries.TakeFakeSurveySecond
{
    public class TakeFakeSurveySecondQuery : IRequest<FakeSurveySecondVm>
    {
        public Guid ZoneId { get; set; }
    }
}
