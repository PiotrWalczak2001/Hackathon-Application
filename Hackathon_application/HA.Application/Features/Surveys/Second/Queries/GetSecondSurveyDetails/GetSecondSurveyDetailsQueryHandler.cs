using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HA.Application.Contracts.Persistence;
using HA.Application.Features.Surveys.Second.Queries.GetSecondSurveyDetails;
using MediatR;

namespace HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails
{
    public class GetSecondSurveyDetailsQueryHandler : IRequestHandler<GetSecondSurveyDetailsQuery, List<SecondSurveyDetailsVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISecondSurveyDetailsRepository _secondSurveyDetailsRepository;

        public GetSecondSurveyDetailsQueryHandler(IMapper mapper, ISecondSurveyDetailsRepository secondSurveyDetailsRepository)
        {
            _secondSurveyDetailsRepository = secondSurveyDetailsRepository;
            _mapper = mapper;
        }
        public async Task<List<SecondSurveyDetailsVm>> Handle(GetSecondSurveyDetailsQuery request, CancellationToken cancellationToken)
        {
            var secondSurveyDetailsList = await _secondSurveyDetailsRepository.GetListOfAll();
            return _mapper.Map<List<SecondSurveyDetailsVm>>(secondSurveyDetailsList);
        }
    }
}
