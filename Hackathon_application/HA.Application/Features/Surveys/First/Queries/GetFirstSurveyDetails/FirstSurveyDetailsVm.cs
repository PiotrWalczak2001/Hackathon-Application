using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails
{
    public class FirstSurveyDetailsVm
    {
        public Guid Id { get; set; }
        public string Survey { get; set; }
        public Guid ZoneId { get; set; }
        public DateTime SurveyDate { get; set; }
    }
}
