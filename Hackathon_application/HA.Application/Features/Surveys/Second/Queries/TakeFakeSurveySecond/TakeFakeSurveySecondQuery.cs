using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Application.Features.Surveys.Second.Queries.TakeFakeSurveySecond
{
    public class TakeFakeSurveySecondQuery : IRequest<FakeSurveySecondVm>
    {
        public Guid ZoneId { get; set; }
    }
}
