using HA.Application.Contracts.Persistence;
using HA.Domain.Enitites;

namespace HA.Persistence.Repositories
{
    public class PriceMultiplierRepository : BaseRepository<PriceMultiplier>, IPriceMultiplierRepository
    {
        public PriceMultiplierRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
