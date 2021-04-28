using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
     public class Request
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string RequestExplanation { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
