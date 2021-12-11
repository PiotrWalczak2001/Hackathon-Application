using HA.UI.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HA.UI.Services
{
    public interface ISurveyService
    {
        Task<List<ZoneListViewModel>> TakeFakeData();
    }
}
