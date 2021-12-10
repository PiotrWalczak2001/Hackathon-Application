using AutoMapper;
using HA.Application.Features.Zone.Queries.GetAllZones;
using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Zone, ZoneListVm>().ReverseMap();
        }
    }
}
