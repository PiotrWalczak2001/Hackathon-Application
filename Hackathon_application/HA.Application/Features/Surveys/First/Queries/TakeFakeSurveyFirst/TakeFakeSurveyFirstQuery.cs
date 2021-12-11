using MediatR;
using System;

namespace HA.Application.Features.Surveys.First.Queries.TakeFakeSurveyFirst
{
    public class TakeFakeSurveyFirstQuery : IRequest<FakeSurveyFirstVm>
    {
        public Guid ZoneId { get; set; }
    }
}
