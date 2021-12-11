using HA.Application.Contracts.Persistence;
using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Persistence.Repositories
{
    public class SurveyFirstRepository : BaseRepository<SurveyFirst>, ISurveyFirstRepository
    {
        public SurveyFirstRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<SurveyFirst> TakeFakeSurveyFirst(Guid zoneId)
        {
            Random rnd = new Random();
            var newSurvey = new SurveyFirst { Id = Guid.NewGuid(), SurveyDate = DateTime.Now, Survey = rnd.Next(1,210).ToString(), ZoneId = zoneId };
            await _dbContext.FirstSurveys.AddAsync(newSurvey);
            await _dbContext.SaveChangesAsync();
            return newSurvey;
        }
    }
}
