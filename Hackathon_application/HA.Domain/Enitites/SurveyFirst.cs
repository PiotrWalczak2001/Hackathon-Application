using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class SurveyFirst
    {
        public Guid Id { get; set; }
        public string Survey { get; set; }
        public Guid ZoneId { get; set; }
        public DateTime SurveyDate { get; set; }
    }
}
