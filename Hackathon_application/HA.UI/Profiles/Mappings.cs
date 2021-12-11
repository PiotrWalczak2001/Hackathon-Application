using AutoMapper;
using HA.Shared;
using HA.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.UI.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Zone, ZoneListViewModel>().ReverseMap();
        }
    }
}
