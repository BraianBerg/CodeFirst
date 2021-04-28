using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class RentedItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
    }
}
