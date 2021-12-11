using System;

namespace HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers
{
    public class MultiplierListVm 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Multiplier { get; set; }
    }
}
