using System;
using MediatR;

namespace HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails
{
    public class GetFirstSurveyDetailsQuery : IRequest<FirstSurveyDetailsVm>
    {
        public Guid FirstSurveyId {get; set;}

    }
}
