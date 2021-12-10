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
    public class GetFirstSurveyDetailsQueryHandler : IRequestHandler<GetFirstSurveyDetailsQuery,FirstSurveyDetailsVm>
    {
        private readonly IMapper _mapper;
        private readonly IFirstSurveyRepository _firstSurveyRepository;

        public GetFirstSurveyDetailsQueryHandler(IMapper mapper, IFirstSurveyRepository firstSurveyRepository)
        {
            _firstSurveyRepository = firstSurveyRepository;
            _mapper = mapper;
        }

        public async Task<FirstSurveyDetailsVm> Handle(GetFirstSurveyDetailsQuery request, CancellationToken cancellationToken)
        {
            var firstSurveyDetails = await _firstSurveyRepository.GetByIdAsync(request.id);
            return _mapper.Map<FirstSurveyDetailsVm>(firstSurveyDetails);
        }
    }
}
