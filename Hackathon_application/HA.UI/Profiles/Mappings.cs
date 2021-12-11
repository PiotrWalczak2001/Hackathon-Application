using AutoMapper;
using HA.Shared;
using HA.UI.ViewModels;

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
