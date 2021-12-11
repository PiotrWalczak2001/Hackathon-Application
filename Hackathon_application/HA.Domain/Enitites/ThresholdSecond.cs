using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Enitites
{
    public class ThresholdSecond // PM 2.5
    {
        public Guid Id { get; set; }
        public int Level { get; set; }
    }
}
