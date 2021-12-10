using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HA.Application.Contracts.Persistence;
using MediatR;

namespace HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers
{
    public class GetAllMultipliersQueryHandler : IRequestHandler<GetAllMultipliersQuery, List<MultiplierListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IPriceMultiplierRepository _priceMultiplierRepository;

        public GetAllMultipliersQueryHandler(IMapper mapper, IPriceMultiplierRepository priceMultiplierRepository)
        {
            _priceMultiplierRepository = priceMultiplierRepository;
            _mapper = mapper;
        }
        
        public async Task<List<MultiplierListVm>> Handle(GetAllMultipliersQuery request, CancellationToken cancellationToken)
        {
            var priceMultiplierList = await _priceMultiplierRepository.GetListOfAll();
            return _mapper.Map<List<MultiplierListVm>>(priceMultiplierList);
        }
    }
}
