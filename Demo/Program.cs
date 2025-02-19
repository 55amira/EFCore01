using Demo.Contexts;
using Demo.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Net.WebSockets;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  AppDbContext context = new AppDbContext();

            //try
            //{
            //    //code
            //}
            //finally
            //{
            //    context.Dispose();
            //}

            //using(AppDbContext context = new AppDbContext())
            //{

            //}

            using AppDbContext context = new AppDbContext();

            #region Create
            //var employee = new Employee()
            //{
            //    Name = "Ahmed ",
            //    Age = 27,
            //    Salary = 15000,
            //    Email = "Ahmed@Ahmed.com",
            //    DateOfCreation = DateTime.Now,

            //};

            //Console.WriteLine(context.Entry(employee).State);

            //context.Employees.Add(employee);
            //Console.WriteLine(context.Entry(employee).State);

            //var result = context.SaveChanges();
            //Console.WriteLine(context.Entry(employee).State);
            //Console.WriteLine(result);
            #endregion

            #region Select
            //    var result = context.Employees.Where(E => E.Id == 1).FirstOrDefault();
            //    Console.WriteLine(result.Name);
            //    Console.WriteLine(result?.Id);

            //var result = context.Employees.Select(E => E.Name);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Update
            //var result = context.Employees.Where(E => E.Id == 3).FirstOrDefault();

            //Console.WriteLine(context.Entry(result).State);

            //result.Name = "Mona";
            //Console.WriteLine(context.Entry(result).State);

            //context.Update(result);

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); 
            #endregion

            var result = context.Employees.FirstOrDefault(E => E.Id == 3);
            context.Employees.Remove(result);
            context.SaveChanges();
        }
    }
}
