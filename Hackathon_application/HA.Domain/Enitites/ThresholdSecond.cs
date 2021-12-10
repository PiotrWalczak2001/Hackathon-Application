using HA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class ThresholdSecond : AuditableEntity // PM 2.5
    {
        public int Level { get; set; }
    }
}
