using HA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class PriceMultiplier : AuditableEntity
    {
        public string Name { get; set; }
        public float Multiplier { get; set; }
        public Guid ThresholdFirstId { get; set; } // PM 10
        public Guid ThresholdSecondId { get; set; } // PM 2.5
    }
}
