using System;
using System.Collections.Generic;
using HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails;
using MediatR;

namespace HA.Application.Features.Surveys.Second.Queries.GetSecondSurveyDetails
{
    public class GetSecondSurveyDetailsQuery : IRequest<SecondSurveyDetailsVm>
    {
        public Guid id;
    }
}
