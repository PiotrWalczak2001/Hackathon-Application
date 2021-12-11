using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Shared
{
    public class PriceMultiplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Multiplier { get; set; }
    }
}
