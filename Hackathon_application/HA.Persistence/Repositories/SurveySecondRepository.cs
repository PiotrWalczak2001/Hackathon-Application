using HA.Application.Contracts.Persistence;
using HA.Domain.Enitites;
using System;
using System.Threading.Tasks;

namespace HA.Persistence.Repositories
{
    public class SurveySecondRepository : BaseRepository<SurveySecond>, ISurveySecondRepository
    {
        public SurveySecondRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<SurveySecond> TakeFakeSurveySecond(Guid zoneId)
        {
            Random rnd = new Random();
            var newSurvey = new SurveySecond { Id = Guid.NewGuid(), SurveyDate = DateTime.Now, Survey = rnd.Next(1, 130).ToString(), ZoneId = zoneId };
            await _dbContext.SecondSurveys.AddAsync(newSurvey);
            await _dbContext.SaveChangesAsync();
            return newSurvey;
        }
    }
}
