using HA.Application.Contracts.Persistence;
using HA.Domain.Enitites;
using System;
using System.Linq;
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
            var zoneToCalculate = _dbContext.Zones.FirstOrDefault(z => z.Id == zoneId);

            var surveyFirst = decimal.Parse(_dbContext.FirstSurveys.FirstOrDefault(sf => sf.Id == zoneToCalculate.SurveyFirstId).Survey);
            var surveySecond = decimal.Parse(_dbContext.SecondSurveys.FirstOrDefault(ss => ss.Id == zoneToCalculate.SurveySecondId).Survey);

            decimal _tempF = 0;
            decimal _tempS = 0;

            if(surveyFirst < 60)
            {
                _tempF = zoneToCalculate.DefaultPrice * 1M;
            }
            else if(surveyFirst > 60 &&  surveyFirst <= 100 )
            {
                _tempF = zoneToCalculate.DefaultPrice * 1.25M;
            }
            else if (surveyFirst > 100 && surveyFirst <= 140)
            {
                _tempF = zoneToCalculate.DefaultPrice * 1.5M;
            }
            else if (surveyFirst > 140 && surveyFirst <= 200 )
            {
                _tempF = zoneToCalculate.DefaultPrice * 2M;
            }
            else if (surveyFirst >= 200)
            {
                _tempF = zoneToCalculate.DefaultPrice * 3M;
            }

            if (surveySecond < 36)
            {
                _tempS = zoneToCalculate.DefaultPrice * 1M;
            }
            else if (surveySecond > 36 && surveySecond <= 60)
            {
                _tempS = zoneToCalculate.DefaultPrice * 1.25M;
            }
            else if (surveySecond > 60 && surveySecond <= 84)
            {
                _tempS = zoneToCalculate.DefaultPrice * 1.5M;
            }
            else if (surveySecond > 84 && surveySecond <= 120)
            {
                _tempS = zoneToCalculate.DefaultPrice * 2M;
            }
            else if (surveySecond >= 120)
            {
                _tempS = zoneToCalculate.DefaultPrice * 3M;
            }

            if(_tempF > _tempS)
            {
                zoneToCalculate.TotalPrice = _tempF;
            }
            else
            {
                zoneToCalculate.TotalPrice = _tempS;
            }

            await _dbContext.SaveChangesAsync();
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
