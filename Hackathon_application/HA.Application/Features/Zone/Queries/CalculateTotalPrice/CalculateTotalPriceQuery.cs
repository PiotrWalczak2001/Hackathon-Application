using MediatR;
using System;

namespace HA.Application.Features.Zone.Queries.CalculateTotalPrice
{
    public class CalculateTotalPriceQuery : IRequest<CalculatedZoneVm>
    {
        public Guid ZoneId { get; set; }
    }
}
