using System;
using HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails;
using MediatR;

namespace HA.Application.Features.Surveys.Second.Queries.GetSecondSurveyDetails
{
    public class GetSecondSurveyDetailsQuery : IRequest<SecondSurveyDetailsVm>
    {
        public Guid SecondSurveyId { get; set; }
    }
}
