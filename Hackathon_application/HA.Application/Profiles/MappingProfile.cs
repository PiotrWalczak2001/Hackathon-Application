using AutoMapper;
using HA.Application.Features.Zone.Queries.GetAllZones;
using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers;
using HA.Application.Features.Zone.Queries.GetZoneById;
using HA.Application.Features.Surveys.Second.Queries.GetFirstSurveyDetails;
using HA.Application.Features.Surveys.First.Queries.GetFirstSurveyDetails;
namespace HA.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Zone, ZoneListVm>().ReverseMap();
            CreateMap<Zone, ZoneDetailsVm>().ReverseMap();

            CreateMap<PriceMultiplier, MultiplierListVm>().ReverseMap();

            CreateMap<SurveyFirst, FirstSurveyDetailsVm>().ReverseMap();
            CreateMap<SurveySecond, SecondSurveyDetailsVm>().ReverseMap();
        }
    }
}
