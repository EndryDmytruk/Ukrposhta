using DB;
using DB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_042022.Controllers
{
    public class PaymentController
    {
        private readonly ContextDB _db;

        public PaymentController(ContextDB context)
        {
            _db = context;
        }

        public string GetPayments(string? filter)
        {
            List<Employee> list;

            if (filter == null)
            {
                list = _db.Employee.ToList();
            }
            else
            {
                var id = _db.Department.Single(x => x.Name == filter).Id;
                list = _db.Employee.Where(x => x.IdDepartment == id).ToList();
            }

            var payments = default(decimal);
            foreach (var row in list)
            {
                payments += row.Salary + row.Salary / 100 * _db.Premium.Single(x => x.Id == row.IdPremium).Value;
            }
            
            return payments.ToString() + "$";
        }

        public List<string> GetDepartments()
        {
            return _db.Department.Select(x => x.Name).ToList();
        }
    }
}
