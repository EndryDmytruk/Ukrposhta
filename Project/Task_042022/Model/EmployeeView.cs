using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_042022.Model
{
    public class EmployeeView
    {
        public int? Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Rating { get; set; }
        public decimal Premium { get; set; }
    }
}
