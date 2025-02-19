using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01.Enitity
{
    // 1. By Convention 
    //internal class Department
    //{

    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public int Inst_ID { get; set; }

    //    public DateTime HiringDate { get; set; }
    //}


    // 2. Data Annotation 
    //class Department
    //{

    //    [Key]public int Id { get; set; }

    //    [Required]
    //    [StringLength(50,MinimumLength =10)]
    //    [MaxLength(50)]
    //    public string Name { get; set; }

    //    [Required]
    //    public int Inst_ID { get; set; }

    //    [DataType(DataType.Date)]
    //    public DateTime HiringDate { get; set; }
    //}

    internal class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int ManagerId { get; set; }

        public Instructor?  Manager { get; set; }
        public DateTime HiringDate { get; set; }

       // public List<Instructor>? Instructors { get; set; }
    }
}
