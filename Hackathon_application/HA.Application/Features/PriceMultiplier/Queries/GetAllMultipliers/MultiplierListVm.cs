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
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Multiplier { get; set; }
    }
}
