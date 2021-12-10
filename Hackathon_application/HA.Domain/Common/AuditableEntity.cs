using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Domain.Common
{
    public abstract class AuditableEntity
    {
        public Guid Id { get; set; }
    }
}
