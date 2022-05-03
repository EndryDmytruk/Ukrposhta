using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DB.Entities.Models
{
    public class Position
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public virtual List<Employee> _Employee { get; set; }
    }
}
