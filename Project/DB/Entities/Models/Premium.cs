using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Entities.Models
{
    public class Premium
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }

        public virtual List<Employee> _Employee { get; set; }
    }
}
