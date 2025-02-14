using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assig01.Enitity
{
    // 1. By Convention 
    //internal class Student
    //{
    //    public int Id { get; set; }
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public string  Address { get; set; }

    //    public int Age { get; set; }

    //    public int Dep_Id { get; set; }
    //}

    // 2. Data Annotation 
    //class Student
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int Id { get; set; }

    //    [Required]
    //    [Column(TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 20)]
    //    public string FName { get; set; }

    //    [Required]
    //    [Column(TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 20)]
    //    public string LName { get; set; }

    //    [NotMapped]
    //    public string  Address { get; set; }
    //    [Range(20, 60)]
    //    public int Age { get; set; }

    //    [Required]
    //    public int Dep_Id { get; set; }
    //}

    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }

        public int Age { get; set; }

        public int Dep_Id { get; set; }
    }
}
