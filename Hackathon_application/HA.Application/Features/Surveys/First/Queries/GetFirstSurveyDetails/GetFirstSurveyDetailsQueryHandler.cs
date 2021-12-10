using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HA.Application.Contracts.Persistence;
using MediatR;

namespace HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails
{
    public class GetFirstSurveyDetailsQueryHandler : IRequestHandler<GetFirstSurveyDetailsQuery,List<FirstSurveyDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly IZoneRepository _firstSurveyDetailsRepository;

        public GetFirstSurveyDetailsQueryHandler(IMapper mapper, IZoneRepository firstSurveyDetailsRepository)
        {
            _firstSurveyDetailsRepository = firstSurveyDetailsRepository;
            _mapper = mapper;
        }

        public async Task<List<FirstSurveyDetailsVm>> Handle(GetFirstSurveyDetailsQuery request, CancellationToken cancellationToken)
        {
            var firstSurveyDetailsList = await _firstSurveyDetailsRepository.GetListOfAll();
            return _mapper.Map<List<FirstSurveyDetailsVm>>(firstSurveyDetailsList);
        }
    }
}
