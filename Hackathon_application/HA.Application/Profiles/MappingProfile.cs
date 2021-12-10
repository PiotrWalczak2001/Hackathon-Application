using AutoMapper;
using HA.Application.Features.Zone.Queries.GetAllZones;
using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers;

namespace HA.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Zone, ZoneListVm>().ReverseMap();
            CreateMap<PriceMultiplier, MultiplierListVm>().ReverseMap();
        }
    }
}
