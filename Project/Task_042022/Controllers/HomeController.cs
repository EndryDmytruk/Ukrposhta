using DB;
using DB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_042022.Model;

namespace Task_042022.Controllers
{
    public class HomeController
    {
        private readonly ContextDB _db;

        public HomeController(ContextDB context)
        {
            _db = context;
        }

        public string GetSortedEmployees()
        {
            var list = GetEmployees(null);
            list.OrderBy(x => x.Department);

            var strText = string.Empty;

            strText += String.Format("{0,-35} {1, -20} {2, -20} {3, -12} {4, -12} {5, -12}\n", "Full name", "Department", "Position", "Salary", "Rating", "Premium");
            foreach (var row in list)
            {
                strText += String.Format("{0,-35} {1, -20} {2, -20} {3, -12:N2} {4, -12} {5, -12:N2}\n", 
                    row.FullName, row.Department, row.Position, row.Salary, row.Rating, row.Premium);
            }

            return strText;
        }

        public List<EmployeeView> GetEmployees(string? filter)
        {
            List<Employee> list;
            if (filter == null)
            {
                list = _db.Employee.ToList();
            }
            else
            {
                var idDepartment = _db.Department.Single(x => x.Name == filter).Id;
                list = _db.Employee.Where(x => x.IdDepartment == idDepartment).ToList();
            }
            
            var getList = new List<EmployeeView>();
            foreach (var row in list)
            {
                var premium = _db.Premium.Single(x => x.Id == row.IdPremium);

                getList.Add(new EmployeeView()
                {
                    FullName = $"{row.Surname} {row.Name} {row.Lastname}",
                    Department = _db.Department.Single(x => x.Id == row.IdDepartment).Name,
                    Position = _db.Position.Single(x => x.Id == row.IdPosition).Name,
                    Rating = $"{premium.Name} - {premium.Value}%",
                    Salary = row.Salary,
                    Premium = Math.Round(row.Salary * premium.Value / 100, 2),
                    Id = row.Code
                });
            }

            return getList;
        }

        public EmployeeEdit GetEmployees(int id)
        {
            var item = _db.Employee.Single(x => x.Code == id);
            var premium = _db.Premium.Single(x => x.Id == item.IdPremium);

            var newItem = new EmployeeEdit()
            {
                Code = item.Code.ToString(),
                Salary = item.Salary.ToString(),
                Address = item.Address,
                Name = item.Name,
                Lastname = item.Lastname,
                Surname = item.Surname,
                Phone = item.Phone,
                Department = _db.Department.Single(x => x.Id == item.IdDepartment).Name,
                Position = _db.Position.Single(x => x.Id == item.IdPosition).Name,
                Premium = $"{premium.Name} - {premium.Value}%"
            };

            return newItem;
        }

        public List<string> GetDepartments()
        { 
            return _db.Department.Select(x => x.Name).ToList();
        }
    }
}
