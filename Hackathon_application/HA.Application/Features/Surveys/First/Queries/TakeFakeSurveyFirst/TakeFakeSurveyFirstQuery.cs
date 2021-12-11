using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Application.Features.Surveys.First.Queries.TakeFakeSurveyFirst
{
    public class TakeFakeSurveyFirstQuery : IRequest<FakeSurveyFirstVm>
    {
        public Guid ZoneId { get; set; }
    }
}
