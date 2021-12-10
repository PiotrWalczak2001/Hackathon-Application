﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Application.Features.Zone.Queries.GetAllZones
{
    public class GetAllZonesQuery : IRequest<List<ZoneListVm>>
    {
    }
}
