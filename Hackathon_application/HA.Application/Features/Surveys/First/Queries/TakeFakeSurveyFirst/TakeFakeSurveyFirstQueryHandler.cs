using AutoMapper;
using HA.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HA.Application.Features.Surveys.First.Queries.TakeFakeSurveyFirst
{
    public class TakeFakeSurveyFirstQueryHandler : IRequestHandler<TakeFakeSurveyFirstQuery, FakeSurveyFirstVm>
    {
        private readonly IMapper _mapper;
        private readonly ISurveyFirstRepository _surveyFirstRepository;
        private readonly IZoneRepository _zoneRepository;
        public TakeFakeSurveyFirstQueryHandler(IMapper mapper, ISurveyFirstRepository surveyFirstRepository, IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
            _surveyFirstRepository = surveyFirstRepository;
            _mapper = mapper;
        }
        public async Task<FakeSurveyFirstVm> Handle(TakeFakeSurveyFirstQuery request, CancellationToken cancellationToken)
        {
            var fakeSurvey = await _surveyFirstRepository.TakeFakeSurveyFirst(request.ZoneId);
            await _zoneRepository.RefreshFirstSurveys(fakeSurvey.ZoneId, fakeSurvey.Id);
            return _mapper.Map<FakeSurveyFirstVm>(fakeSurvey);
        }
    }
}
