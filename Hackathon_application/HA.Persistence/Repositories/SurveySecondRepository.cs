using HA.Application.Contracts.Persistence;
using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Persistence.Repositories
{
    public class SurveySecondRepository : BaseRepository<SurveySecond>, ISurveySecondRepository
    {
        public SurveySecondRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<SurveySecond> TakeFakeSurveySecond()
        {
            Random rnd = new Random();
            var newSurvey = new SurveySecond { Id = Guid.NewGuid(), SurveyDate = DateTime.Now, Survey = rnd.Next(1, 500).ToString() };
            await _dbContext.SecondSurveys.AddAsync(newSurvey);
            return newSurvey;
        }
    }
}
