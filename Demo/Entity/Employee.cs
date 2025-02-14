using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    // EF Core Support 4 Ways For Mapping Class in DataBase [ table - View - Function ]
    // 1. By Convention [ Defult Behaviour ]    /// Table
    // 2. Data Annotation [Set Of Attributes  Used For Data Validation]
    // 3. Fluent APIs
    // 4. Configuration Class


    //Entity
    //POCO
    //Plain OLD CLR Object
    //internal class Employee // table
    //{
    //    public int Id { get; set; } // Public Numeric Property Named Id | EmployeeId --> PK , Identity (1,1)
    //    public string Name { get; set; } // Refernce Type : Required [ Not Allow Null ] - nvarchar(max)
    //    public int? Age { get; set; } // Nullable Value Type : int[Age] - OPtional [ Allow Null ] 
    //    public double Salary { get; set; } // Value Type  : float[Salary] - Required
    //    public string? Email { get; set; } // Nullable nvarchar(max) Optional
    //    public DateTime DateOfCreation { get; set; } // datetime2  - Required


    //}

    // 2. Data Annotation 
    // [Table("Employee", Schema = "dbo")]
    //class Employee 
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName" , TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength (50,MinimumLength =10)]
    //    public string? Name { get; set; }

    //    [Range (20,60)]
    //    public int Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; } // Examable@examble.com

    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public int PhoneNumber { get; set; }

    //    [Column (TypeName = "money")]
    //   [ DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }

    //    public string Password { get; set; }
    //}

    class Employee // table
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
