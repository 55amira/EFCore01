using Assig01.Context;
using Assig01.Enitity;
using System.Net;

namespace Assig01
{
    internal class Program
    {
        static void Main()
        {
           using ItiDbContext context = new ItiDbContext();



            #region  Create
            //var Student = new Student()
            //{

            //    LName = "Ali",
            //    FName = "Ahmed",
            //    Age = 18 ,
            //    Address = "Cairo",
            //    DepartmentId = null
            //};

            //context.Students.Add(Student);

            //var course = new Course()
            //{
            //    Id = 1,
            //    Name = "IS",
            //    Description = "Information System",
            //    Duration = "3 M",

            //};
            //context.Courses.Add(course);

            //var instructor = new Instructor()
            //{
            //    Id = 1,
            //    Name = "Mohamed"

            //};
            //context.Instructors.Add(instructor);

            //context.SaveChanges(); 
            #endregion

            #region Select
            //Select
            //var result = context.Students.Select(S => S.Id == 1).FirstOrDefault();
            //  Console.WriteLine(result);

            //var result = context.Departments.Select(S => S.Id == 1).FirstOrDefault();
            //Console.WriteLine(result); 
            #endregion

            #region Update
            //var result = context.Students.Where(S => S.Id == 1).FirstOrDefault();
            //result.FName = "Omer";
            //context.Update(result);
            //context.SaveChanges();

            //var result = context.Departments.Where(D => D.Name == "IS").FirstOrDefault();
            //result.Name = "CS";
            //context.Update(result);
            //context.SaveChanges(); 
            #endregion

            #region Delete
            //var result = context.Students.Where(S => S.Id == 1);
            //context.Remove(result);
            //context.SaveChanges(); 
            #endregion




        }
    }
}
