using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HA.Domain.Enitites;

namespace HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers
{
    public class MultiplierListVm 
    {
        public string Name { get; set; }
        public double Multiplier { get; set; }
        public Guid ThresholdFirstId { get; set; } // PM 10
        public Guid ThresholdSecondId { get; set; } // PM 2.5
    }
}
