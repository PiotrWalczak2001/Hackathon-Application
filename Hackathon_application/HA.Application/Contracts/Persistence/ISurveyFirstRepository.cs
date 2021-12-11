using HA.Domain.Enitites;
using System;
using System.Threading.Tasks;

namespace HA.Application.Contracts.Persistence
{
    public interface ISurveyFirstRepository : IAsyncRepository<SurveyFirst>
    {
        Task<SurveyFirst> TakeFakeSurveyFirst(Guid zoneId);
    }
}
