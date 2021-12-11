using HA.UI.Services;
using HA.UI.ViewModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.UI.Pages
{
    public partial class ReloadData
    {
        public ICollection<ZoneListViewModel> Zones { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IZoneService ZoneService { get; set; }
        [Inject]
        public ISurveyService SurveyService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Zones = (await SurveyService.TakeFakeData()).ToList();
            NavigationManager.NavigateTo("/");
        }
    }
}
