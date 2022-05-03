using Common;
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
    public class EmployeeController
    {
        private readonly ContextDB _db;

        public EmployeeController(ContextDB context)
        {
            _db = context;
        }

        public StatusOperation AddRow(EmployeeEdit row)
        {
            try
            {
                var item = new Employee()
                {
                    Code = Convert.ToInt32(row.Code),
                    Name = row.Name,
                    Surname = row.Surname,
                    Lastname = row.Lastname,
                    Address = row.Address,
                    Phone = row.Phone,
                    Salary = Convert.ToDecimal(row.Salary),
                    IdDepartment = _db.Department.SingleOrDefault(x => x.Name == row.Department)!.Id
                            ?? throw new Exception("Відповідного значення відділу не знайдено!"),
                    IdPosition = _db.Position.SingleOrDefault(x => x.Name == row.Position)!.Id
                            ?? throw new Exception("Відповідного значення відділу не знайдено!"),
                    IdPremium = _db.Premium.SingleOrDefault(x => x.Name == row.Premium.Substring(0, row.Premium.IndexOf(' ')))!.Id
                            ?? throw new Exception("Відповідного значення відділу не знайдено!")
                };

                _db.Employee.Add(item);
                _db.SaveChanges();

                return new StatusOperation() { Code = StatusCode.Ok };
            }
            catch (Exception ex)
            {

                UndoChanges.Undo(_db);
                var exception = ex.InnerException == null ? ex : ex.InnerException;
                return new StatusOperation() { Code = StatusCode.Exception, GetException = exception };
            }
        }

        public StatusOperation DeleteRow(string id)
        {
            try
            {
                var item = _db.Employee.SingleOrDefault(x => x.Code == Convert.ToInt32(id));
                _db.Employee.Remove(item!);
                _db.SaveChanges();

                return new StatusOperation() { Code = StatusCode.Ok };
            }
            catch (Exception ex)
            {
                var exception = ex.InnerException == null ? ex : ex.InnerException;
                return new StatusOperation() { Code = StatusCode.Exception, GetException = exception };
            }
        }

        public StatusOperation UpdateRow(EmployeeEdit row)
        {
            try
            {
                var item = _db.Employee.Single(x => x.Code == Convert.ToInt32(row.Code));

                item.Name = row.Name;
                item.Surname = row.Surname;
                item.Lastname = row.Lastname;
                item.Address = row.Address;
                item.Phone = row.Phone;
                    item.Salary = Convert.ToDecimal(row.Salary);
                item.IdDepartment = _db.Department.SingleOrDefault(x => x.Name == row.Department)!.Id
                        ?? throw new Exception("Відповідного значення відділу не знайдено!");
                item.IdPosition = _db.Position.SingleOrDefault(x => x.Name == row.Position)!.Id
                        ?? throw new Exception("Відповідного значення відділу не знайдено!");
                item.IdPremium = _db.Premium.SingleOrDefault(x => x.Name == row.Premium.Substring(0, row.Premium.IndexOf(' ')))!.Id
                        ?? throw new Exception("Відповідного значення відділу не знайдено!");

                _db.SaveChanges();

                return new StatusOperation() { Code = StatusCode.Ok };
            }
            catch (Exception ex)
            {
                UndoChanges.Undo(_db);
                var exception = ex.InnerException == null ? ex : ex.InnerException;
                return new StatusOperation() { Code = StatusCode.Exception, GetException = exception };
            }
        }

        public List<string> GetDepartments()
        {
            return _db.Department.Select(x => x.Name).ToList();
        }

        public List<string> GetPositions()
        {
            return _db.Position.Select(x => x.Name).ToList();
        }

        public List<string> GetPremiums()
        {
            return _db.Premium.Select(x => $"{x.Name} - {x.Value}%").ToList();
        }
    }
}
