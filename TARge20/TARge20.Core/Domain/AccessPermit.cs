using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessPermit
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
    }
}
