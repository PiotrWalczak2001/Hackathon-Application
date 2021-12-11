﻿using AutoMapper;
using HA.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HA.Application.Features.Surveys.Second.Queries.TakeFakeSurveySecond
{
    public class TakeFakeSurveySecondQueryHandler : IRequestHandler<TakeFakeSurveySecondQuery ,FakeSurveySecondVm>
    {
        private readonly IMapper _mapper;
        private readonly ISurveySecondRepository _surveySecondRepository;
        private readonly IZoneRepository _zoneRepository;
        public TakeFakeSurveySecondQueryHandler(IMapper mapper, ISurveySecondRepository surveySecondRepository, IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
            _surveySecondRepository = surveySecondRepository;
            _mapper = mapper;
        }

        public async Task<FakeSurveySecondVm> Handle(TakeFakeSurveySecondQuery request, CancellationToken cancellationToken)
        {
            var fakeSurvey = await _surveySecondRepository.TakeFakeSurveySecond(request.ZoneId);
            await _zoneRepository.RefreshSecondSurveys(fakeSurvey.ZoneId, fakeSurvey.Id);
            return _mapper.Map<FakeSurveySecondVm>(fakeSurvey);
        }
    }
}
