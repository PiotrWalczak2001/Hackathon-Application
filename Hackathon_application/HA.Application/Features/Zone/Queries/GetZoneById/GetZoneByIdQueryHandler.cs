using AutoMapper;
using HA.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HA.Application.Features.Zone.Queries.GetZoneById
{
    public class GetZoneByIdQueryHandler : IRequestHandler<GetZoneByIdQuery, ZoneDetailsVm>
    {
        private readonly IMapper _mapper;
        private readonly IZoneRepository _zoneRepository;
        public GetZoneByIdQueryHandler(IMapper mapper, IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
            _mapper = mapper;
        }

        public async Task<ZoneDetailsVm> Handle(GetZoneByIdQuery request, CancellationToken cancellationToken)
        {
            var zoneDetails = await _zoneRepository.GetByIdAsync(request.ZoneId);
            return _mapper.Map<ZoneDetailsVm>(zoneDetails);
        }
    }
}
