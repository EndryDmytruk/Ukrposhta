using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Entities.Models
{
    public class Employee
    {
        public int? Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int IdDepartment { get; set; }
        public int IdPosition { get; set; }
        public decimal Salary { get; set; }
        public int IdPremium { get; set; }

        public virtual Department _Department { get; set; }
        public virtual Position _Position { get; set; }
        public virtual Premium _Premium { get; set; }
    }
}
