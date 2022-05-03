using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return "asd";
        }

        public List<string> GetDepartments()
        { 
            return _db.Department.Select(x => x.Name).ToList();
        }

        public ContextDB GetContextDb()
        {
            return _db;
        }
    }
}
