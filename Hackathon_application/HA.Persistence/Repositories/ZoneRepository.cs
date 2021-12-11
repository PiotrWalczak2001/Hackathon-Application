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

        public void RefreshSurveys(Guid zoneId)
        {
            var newSurvey = _dbContext.FirstSurveys.Where(s => s.ZoneId == zoneId).OrderBy(x => x.SurveyDate).FirstOrDefault();
            var zoneToUpdate = _dbContext.Zones.FirstOrDefault(z => z.Id == zoneId);
            zoneToUpdate.SurveyFirstId = newSurvey.Id;
        }

    }
}
