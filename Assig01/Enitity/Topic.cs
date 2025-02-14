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
    //internal class Topic
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    // 2. Data Annotation 
    //class Topic
    //{
    //    [Key]
    //    public int Id { get; set; }

    //    [Required]

    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 20)]
    //    public string Name { get; set; }
    //}

    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
