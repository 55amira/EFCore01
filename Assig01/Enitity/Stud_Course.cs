using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01.Enitity
{
    // 1. By Convention 
    //internal class Stud_Course
    //{

    //    public int StudId { get; set; }

    //    public int Course_ID { get; set; }

    //    public int Grade { get; set; }
    //}

    // 2. Data Annotation 
    //class Stud_Course
    //{
    //    [Key]
    //    public int StudId { get; set; }

    //    [Key]
    //    public int Course_ID { get; set; }

    //    [Required]
    //    public int Grade { get; set; }
    //}

    internal class Stud_Course
    {

        public int StudId { get; set; }

        public int Course_ID { get; set; }

        public int Grade { get; set; }
    }
}
