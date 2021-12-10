using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Shared
{
    public class Zone
    {
        public string ZoneName { get; set;}
        public decimal DefaultPrice { get; set; }
        public Guid SurveyFirstId { get; set; }
        public SurveyFirst SurveyFirst { get; set; }
        public Guid SurveySecondId { get; set; }
        public SurveySecond SurveySecond { get; set; }
    }
}
