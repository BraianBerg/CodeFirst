using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Children
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }
    }
}
