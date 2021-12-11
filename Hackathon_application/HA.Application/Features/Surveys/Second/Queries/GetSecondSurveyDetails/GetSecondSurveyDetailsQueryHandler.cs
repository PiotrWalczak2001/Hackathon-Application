using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HA.Application.Contracts.Persistence;
using HA.Application.Features.Surveys.Second.Queries.GetSecondSurveyDetails;
using MediatR;

namespace HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails
{
    public class GetSecondSurveyDetailsQueryHandler : IRequestHandler<GetSecondSurveyDetailsQuery, SecondSurveyDetailsVm>
    {
        private readonly IMapper _mapper;
        private readonly ISurveySecondRepository _secondSurveyRepository;

        public GetSecondSurveyDetailsQueryHandler(IMapper mapper, ISurveySecondRepository secondSurveyDetailsRepository)
        {
            _secondSurveyRepository = secondSurveyDetailsRepository;
            _mapper = mapper;
        }
        public async Task<SecondSurveyDetailsVm> Handle(GetSecondSurveyDetailsQuery request, CancellationToken cancellationToken)
        {
            var secondSurveyDetails = await _secondSurveyRepository.GetByIdAsync(request.SecondSurveyId);
            return _mapper.Map<SecondSurveyDetailsVm>(secondSurveyDetails);
        }
    }
}
