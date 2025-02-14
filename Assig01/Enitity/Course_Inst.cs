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
    //internal class Course_Inst
    //{
    //    public int Int_Id { get; set; }
    //    public int Course_Id { get; set; }

    //    public string evaluate { get; set; }
    //}


    // 2. Data Annotation 
    //class Course_Inst
    //{
    //    [Key]
    //    public int Int_Id { get; set; }

    //    [Key]
    //    public int Course_Id { get; set; }

    //    [Column(TypeName = "varchar")]
    //      [MaxLength(50)]
    //    public string evaluate { get; set; }
    //}

    internal class Course_Inst
    {
        public int Int_Id { get; set; }
        public int Course_Id { get; set; }

        public string evaluate { get; set; }
    }
}
