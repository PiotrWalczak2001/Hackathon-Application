using MediatR;
using System.Collections.Generic;

namespace HA.Application.Features.Zone.Queries.GetAllZones
{
    public class GetAllZonesQuery : IRequest<List<ZoneListVm>>
    {
    }
}
