using AutoMapper;
using HA.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HA.Application.Features.Zone.Queries.GetAllZones
{
    public class GetAllZonesQueryHandler : IRequestHandler<GetAllZonesQuery, List<ZoneListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IZoneRepository _zoneRepository;
        public GetAllZonesQueryHandler(IMapper mapper, IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
            _mapper = mapper;
        }
        public async Task<List<ZoneListVm>> Handle(GetAllZonesQuery request, CancellationToken cancellationToken)
        {
            var zoneList = (await _zoneRepository.GetListOfAll()).OrderBy(z => z.ZoneName);
            return _mapper.Map<List<ZoneListVm>>(zoneList);
        }
    }
}
