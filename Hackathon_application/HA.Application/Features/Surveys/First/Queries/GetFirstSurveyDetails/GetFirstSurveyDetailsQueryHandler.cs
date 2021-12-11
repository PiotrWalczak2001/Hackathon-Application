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
        private readonly ISurveyFirstRepository _firstSurveyRepository;

        public GetFirstSurveyDetailsQueryHandler(IMapper mapper, ISurveyFirstRepository firstSurveyRepository)
        {
            _firstSurveyRepository = firstSurveyRepository;
            _mapper = mapper;
        }

        public async Task<FirstSurveyDetailsVm> Handle(GetFirstSurveyDetailsQuery request, CancellationToken cancellationToken)
        {
            var firstSurveyDetails = await _firstSurveyRepository.GetByIdAsync(request.FirstSurveyId);
            return _mapper.Map<FirstSurveyDetailsVm>(firstSurveyDetails);
        }
    }
}
