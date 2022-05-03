using System.ComponentModel.DataAnnotations;

namespace DB.Entities.Models
{
    public class Department
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public virtual List<Employee> _Employee { get; set; }
    }
}
