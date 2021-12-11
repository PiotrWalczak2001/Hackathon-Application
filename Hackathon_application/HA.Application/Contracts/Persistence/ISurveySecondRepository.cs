using HA.Domain.Enitites;
using System;
using System.Threading.Tasks;

namespace HA.Application.Contracts.Persistence
{
    public interface ISurveySecondRepository : IAsyncRepository<SurveySecond>
    {
        Task<SurveySecond> TakeFakeSurveySecond(Guid zoneId);
    }
}
