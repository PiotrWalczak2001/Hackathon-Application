using HA.UI.Services;
using HA.UI.ViewModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.UI.Pages
{
    public partial class MainMap
    {
        public ICollection<ZoneListViewModel> Zones { get; set; }
        [Inject]
        public IZoneService ZoneService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Zones = (await ZoneService.GetAllZones()).ToList();
        }
    }
}
