using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    internal class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }

        // [ForeignKey("Manager")]
        // [ForeignKey(nameof(Department.Manager))]
       public int ManagerId { get; set; }
       public Employee Manager { get; set; } // Navigation Property

        public List<Employee> Employees { get; set; }
    }
}
