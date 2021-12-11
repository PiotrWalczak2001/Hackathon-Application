using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Application.Contracts.Persistence
{
    public interface ISurveySecondRepository : IAsyncRepository<SurveySecond>
    {
        Task<SurveySecond> TakeFakeSurveySecond(Guid zoneId);
    }
}
