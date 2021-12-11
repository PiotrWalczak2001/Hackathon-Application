using MediatR;
using System;

namespace HA.Application.Features.Zone.Queries.GetZoneById
{
    public class GetZoneByIdQuery : IRequest<ZoneDetailsVm>
    {
        public Guid ZoneId { get; set; }
    }
}
