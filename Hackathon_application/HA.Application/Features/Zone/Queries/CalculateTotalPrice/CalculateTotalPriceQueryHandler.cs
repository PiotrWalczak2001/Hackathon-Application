using AutoMapper;
using HA.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HA.Application.Features.Zone.Queries.CalculateTotalPrice
{
    public class CalculateTotalPriceQueryHandler : IRequestHandler<CalculateTotalPriceQuery, CalculatedZoneVm>
    {
        private readonly IMapper _mapper;
        private readonly IZoneRepository _zoneRepository;
        public CalculateTotalPriceQueryHandler(IMapper mapper, IZoneRepository zoneRepository)
        {
            _mapper = mapper;
            _zoneRepository = zoneRepository;
        }
        public async Task<CalculatedZoneVm> Handle(CalculateTotalPriceQuery request, CancellationToken cancellationToken)
        {
            await _zoneRepository.CalculateTotalPrice(request.ZoneId);
            var calculatedZone = await _zoneRepository.GetByIdAsync(request.ZoneId);
            return _mapper.Map<CalculatedZoneVm>(calculatedZone);
        }
    }
}
