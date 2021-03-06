using Common;
using DB;
using DB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_042022.Controllers
{
    public class DepartmentController
    {
        private readonly ContextDB _db;

        public DepartmentController(ContextDB context)
        { 
            _db = context;
        }

        public List<Department> GetAll()
        { 
            return _db.Department.ToList();
        }

        public StatusOperation AddRow(string id, string name)
        {
            try
            {
                if (id != String.Empty)
                {
                    throw new Exception("Id мустить бути пустим, для цього натисність кнопку відмана!");
                }

                if (name == string.Empty)
                {
                    name = null;
                }


                var newItem = new Department()
                {
                    Name = name
                };

                _db.Add(newItem);
                _db.SaveChanges();

                return new StatusOperation() { Code = StatusCode.Ok };
            }
            catch (Exception ex)
            {
                var exception = ex.InnerException == null ? ex : ex.InnerException;
                return new StatusOperation() { Code = StatusCode.Exception, GetException = exception };
            }
        }

        public StatusOperation UpdateRow(string id, string name)
        {
            try
            {
                if (id == String.Empty)
                {
                    throw new Exception("Id має містити значення для оновлення запису!");
                }

                if (name == string.Empty)
                {
                    name = null;
                }

                var item = _db.Department.SingleOrDefault(x => x.Id == Convert.ToInt32(id));

                if (item!.Name == name)
                {
                    throw new Exception("Спочатку змініть запис!");
                }

                item!.Name = name;

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
                if (id == String.Empty)
                {
                    throw new Exception("Id має містити значення для видалення запису!");
                }

                var item = _db.Department.SingleOrDefault(x => x.Id == Convert.ToInt32(id));
                _db.Department.Remove(item!);
                _db.SaveChanges();

                return new StatusOperation() { Code = StatusCode.Ok };
            }
            catch (Exception ex)
            {
                var exception = ex.InnerException == null ? ex : ex.InnerException;
                return new StatusOperation() { Code = StatusCode.Exception, GetException = exception };
            }
        }
    }
}
