using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class Zone
    {
        public Guid Id { get; set; }
        public string ZoneName { get; set;}
        public decimal DefaultPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid SurveyFirstId { get; set; }
        public Guid SurveySecondId { get; set; }
    }
}
