using HA.Application.Contracts.Persistence;
using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Persistence.Repositories
{
    public class ZoneRepository : BaseRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task CalculateTotalPrice(Guid zoneId)
        {
            
        }

        public async Task RefreshFirstSurveys(Guid zoneId, Guid newSurveyGuid)
        {
            var zoneToUpdate = _dbContext.Zones.FirstOrDefault(z => z.Id == zoneId);
            zoneToUpdate.SurveyFirstId = newSurveyGuid;
            await _dbContext.SaveChangesAsync();
        }

        public async Task RefreshSecondSurveys(Guid zoneId, Guid newSurveyGuid)
        {
            var zoneToUpdate = _dbContext.Zones.FirstOrDefault(z => z.Id == zoneId);
            zoneToUpdate.SurveySecondId = newSurveyGuid;
            await _dbContext.SaveChangesAsync();
        }

        

    }
}
