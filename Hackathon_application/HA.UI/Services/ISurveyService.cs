﻿using HA.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HA.UI.Services
{
    public interface ISurveyService
    {
        Task<List<ZoneListViewModel>> TakeFakeData();
    }
}
