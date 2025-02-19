using Demo.Configuration;
using Demo.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class AppDbContext : DbContext
    {
        // Microsoft.EntityFrameworkCore


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 3. Fiuent APIs
            // modelBuilder.Entity<Employee>().HasKey("EmpId");
            // modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));

            //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

            //modelBuilder.Entity<Employee>().Property(E => E.Name)
            //                               .IsRequired()
            //                               .HasColumnName("EmployeeName")
            //                               .HasColumnType("varchar")
            //                               .HasMaxLength(50);
            //modelBuilder.Entity<Employee>().Property(E => E.Age).IsRequired(false);

            //modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("money");

            // modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);

            //modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<Employee>(E =>
            //{
            //   E.HasKey(E => E.EmpId);

            //    E.Property(E => E.Name)
            //                                   .IsRequired()
            //                                   .HasColumnName("EmployeeName")
            //                                   .HasColumnType("varchar")
            //                                   .HasMaxLength(50);

            //    E.Property(E => E.Age).IsRequired(false);

            //    E.Property(E => E.Salary).HasColumnType("money");

            //    E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
            //}); 
            #endregion

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<Employee>().HasOne(E => E.Department)
            //                               .WithOne(D => D.Manager)
            //                               .HasForeignKey<Department>(D => D.ManagerId);

            modelBuilder.Entity<Department>().HasOne(D => D.Manager)
                                             .WithOne(D => D.Department)
                                             .HasForeignKey<Department>(D => D.ManagerId);

            modelBuilder.Entity<Department>().HasMany( D => D.Employees)
                                             .WithOne( E => E.WorkFor)
                                             .HasForeignKey( E => E.WorkForId);

            modelBuilder.Entity<StudentCourse>().HasKey(Sc => new {Sc.StudentId, Sc.CourseId});

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext () : base ()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =  DESKTOP-LA0JIU9\\MSSQLSERVER01; Database = App; Trusted_Connection = True;TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
