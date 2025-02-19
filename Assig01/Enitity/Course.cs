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
    //internal class Course
    //{
    //    public int Id { get; set; }

    //    public int Top_ID { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public string Duration { get; set; }
    //}


    // 2. Data Annotation 
    //class Course
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int Id { get; set; }

    //    [Required]
    //    public int Top_ID { get; set; }

    //    [Required]
    //    [Column( TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(100,MinimumLength =20)]
    //    public string Name { get; set; }

    //    [Column(TypeName = "varchar")]
    //    [MaxLength(50)]
    //    public string Description { get; set; }

    //    [Column(TypeName = "varchar")]
    //    [MaxLength(50)]
    //    public string Duration { get; set; }
    //}

    internal class Course
    {
        public int Id { get; set; }

        public int? TopicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }

        public List<Stud_Course>? Students { get; set; }
        public List<Course_Inst>? Instructors { get; set; }
        public Topic? Topic { get; set; }
    }
}
