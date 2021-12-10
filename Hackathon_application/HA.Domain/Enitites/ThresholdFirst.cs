using HA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class ThresholdFirst : AuditableEntity // PM 10
    {
        public int Level { get; set; }
    }
}
