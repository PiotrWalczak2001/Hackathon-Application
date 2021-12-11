using AutoMapper;
using HA.Application.Features.Zone.Queries.GetAllZones;
using HA.Domain.Enitites;
using HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers;
using HA.Application.Features.Zone.Queries.GetZoneById;
using HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails;
using HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails;
using HA.Application.Features.Surveys.First.Queries.TakeFakeSurveyFirst;
using HA.Application.Features.Surveys.Second.Queries.TakeFakeSurveySecond;
using HA.Application.Features.Zone.Queries.CalculateTotalPrice;

namespace HA.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Zone, ZoneListVm>().ReverseMap();
            CreateMap<Zone, ZoneDetailsVm>().ReverseMap();
            CreateMap<Zone, CalculatedZoneVm>().ReverseMap();

            CreateMap<PriceMultiplier, MultiplierListVm>().ReverseMap();

            CreateMap<SurveyFirst, FirstSurveyDetailsVm>().ReverseMap();
            CreateMap<SurveySecond, SecondSurveyDetailsVm>().ReverseMap();

            CreateMap<SurveyFirst, FakeSurveyFirstVm>().ReverseMap();
            CreateMap<SurveySecond, FakeSurveySecondVm>().ReverseMap();

        }
    }
}
