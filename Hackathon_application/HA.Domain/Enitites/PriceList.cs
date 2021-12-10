using HA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class PriceList : AuditableEntity
    {
        public decimal PriceMultiplier { get; set; }
        public string Threshold { get; set; }
    }
}
