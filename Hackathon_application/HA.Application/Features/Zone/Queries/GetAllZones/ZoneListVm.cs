using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Application.Features.Zone.Queries.GetAllZones
{
    public class ZoneListVm
    {
        public Guid Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string ZoneName { get; set; }
    }
}
