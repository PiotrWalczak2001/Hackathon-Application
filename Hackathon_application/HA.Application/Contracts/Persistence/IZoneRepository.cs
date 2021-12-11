using HA.Domain.Enitites;
using System;
using System.Threading.Tasks;

namespace HA.Application.Contracts.Persistence
{
    public interface IZoneRepository : IAsyncRepository<Zone>
    {
        Task RefreshFirstSurveys(Guid zoneId, Guid newSurveyGuid);
        Task RefreshSecondSurveys(Guid zoneId, Guid newSurveyGuid);
        Task CalculateTotalPrice(Guid zoneId);
    }
}
