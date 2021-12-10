using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails
{
    public class GetFirstSurveyDetailsQuery : IRequest<List<FirstSurveyDetailsVm>>
    {
    }
}
