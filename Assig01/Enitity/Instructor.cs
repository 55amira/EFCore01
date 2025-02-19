using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01.Enitity
{
    // 1. By Convention 
    //internal class Instructor
    //{
    //    public int Id { get; set; }


    //    public string Name { get; set; }

    //    public double Bouns { get; set; }

    //    public double Salary { get; set; }

    //    public int HourRate { get; set; }


    //    public int Dept_ID { get; set; }
    //}

    // 2. Data Annotation 
    //class Instructor
    //{
    //    [Key]
    //    public int Id { get; set; }

    //    [Required]

    //    [MaxLength(50)]
    //    [StringLength(100, MinimumLength = 20)]
    //    public string Name { get; set; }

    //    [Required]
    //    public double Bouns { get; set; }

    //    [Required]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public int HourRate { get; set; }

    //    [Required]
    //    public int Dept_ID { get; set; }
    //}

    internal class Instructor
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public double Bouns { get; set; }

        public double Salary { get; set; }

        public int HourRate { get; set; }


       //public int DepartmentId { get; set; }
       //
       //public Department? Department { get; set; }

        public List<Course_Inst>? Courses { get; set; }
    }
}
