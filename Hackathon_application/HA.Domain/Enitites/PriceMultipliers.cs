using System;

namespace HA.Domain.Enitites
{
    public class PriceMultiplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Multiplier { get; set; }
    }
}
