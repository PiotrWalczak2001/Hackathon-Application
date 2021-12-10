using HA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class Zone : AuditableEntity
    {
        public string ZoneName { get; set;}
        public string Contamination { get; set; }
    }
}
