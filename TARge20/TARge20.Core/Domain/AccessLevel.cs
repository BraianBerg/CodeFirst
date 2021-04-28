using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public  class AccessLevel
    {
        public Guid Id { get; set; }
        public enum AccessType
        {
            low,
            medium,
            high,
            special

        }
    }
}
