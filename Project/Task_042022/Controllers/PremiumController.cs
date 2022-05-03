using Common;
using DB;
using DB.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Task_042022.Controllers
{
    public class PremiumController
    {
        private readonly ContextDB _db;

        public PremiumController(ContextDB context)
        {
            _db = context;
        }

        public List<Premium> GetAll()
        {
            return _db.Premium.ToList();
        }

        public StatusOperation AddRow(string id, string name, string value)
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

                var newItem = new Premium()
                {
                    Name = name,
                    Value = Convert.ToDecimal(value)
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

        public StatusOperation UpdateRow(string id, string name, string value)
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

                var item = _db.Premium.SingleOrDefault(x => x.Id == Convert.ToInt32(id));

                if (item!.Name == name && item!.Value == Convert.ToDecimal(value))
                {
                    throw new Exception("Спочатку змініть запис!");
                }

                item!.Name = name;
                item!.Value = Convert.ToDecimal(value);

                _db.SaveChanges(true);

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

                var item = _db.Premium.SingleOrDefault(x => x.Id == Convert.ToInt32(id));
                _db.Premium.Remove(item!);
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
