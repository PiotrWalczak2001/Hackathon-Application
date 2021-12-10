﻿using HA.Application.Contracts.Persistence;
using HA.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Persistence.Repositories
{
    public class PriceMultiplierRepository : BaseRepository<PriceMultiplier>, IPriceMultiplierRepository
    {
        public PriceMultiplierRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}