using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public List<StudentCourse> Courses { get; set; }
    }
}
