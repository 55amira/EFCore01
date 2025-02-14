using Assig01.Configuration;
using Assig01.Enitity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig01.Context
{
    internal class ItiDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 3. Fluent APIs
            //modelBuilder.Entity<Student>( S => {

            //    S.HasKey(S => S.Id);

            //    S.Property(S => S.FName).IsRequired()
            //                                            .HasColumnType("varchar")  
            //                                            .HasMaxLength(50);
            //    S.Property(S => S.LName).IsRequired()
            //                                           .HasColumnType("varchar")
            //                                           .HasMaxLength(50);
            //    S.Property(S => S.Age).IsRequired(false);
            //    S.Property(S => S.Address).IsRequired(false)
            //                                             .HasColumnType("varchar")
            //                                             .HasMaxLength(50);
            //    S.Property(S => S.Dep_Id).IsRequired();
            //});

            //modelBuilder.Entity<Course>(C =>
            //{
            //    C.HasKey(S => S.Id);
            //    C.Property(C =>C.Description).IsRequired(false)
            //                                                 .HasColumnType("varchar")
            //                                                  .HasMaxLength(50);
            //    C.Property(C=>C.Name).IsRequired()
            //                                         .HasColumnType("varchar")
            //                                                  .HasMaxLength(50);
            //    C.Property(C => C.Duration).IsRequired();
            //    C.Property( C => C.Top_ID).IsRequired();
            //});

            //modelBuilder.Entity<Course_Inst>(C =>
            //{
            //    C.HasKey(C => new { C.Course_Id, C.Int_Id });
            //    C.Property(C=> C.evaluate).IsRequired();

            //});
            //modelBuilder.Entity<Department>(D => { 
            //    D.HasKey(D=>D.Id);
            //    D.Property(D => D.Name).IsRequired().HasColumnType("nvarchar")
            //                                           .HasMaxLength(50);
            //    D.Property(D=> D.Inst_ID).IsRequired();
            //    D.Property(D => D.HiringDate).HasDefaultValueSql("GETDAtE()");
            //});
            //modelBuilder.Entity<Instructor>(I => {

            //    I.HasKey(I => I.Id);
            //    I.Property(I => I.Name).IsRequired().HasColumnType("nvarchar")
            //                                           .HasMaxLength(50);
            //    I.Property(I => I.Dept_ID).IsRequired();
            //    I.Property(I => I.Bouns).IsRequired();
            //    I.Property( I=>I.Salary).IsRequired();
            //    I.Property( I => I.HourRate).IsRequired();

            //});
            //modelBuilder.Entity<Stud_Course>(SC => { 
            //    SC.HasKey(SC => new {SC.Course_ID,SC.StudId});
            //    SC.Property(SC =>SC.Grade).IsRequired();

            //});
            //modelBuilder.Entity<Topic>(T => {

            //    T.HasKey(T => T.Id);
            //    T.Property(T => T.Name).IsRequired().HasColumnType("nvarchar")
            //                                           .HasMaxLength(50);

            //});
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseCongfiduration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public ItiDbContext () : base () { }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Server =  DESKTOP-LA0JIU9\\MSSQLSERVER01; Database = ti; Trusted_Connection = True;TrustServerCertificate = True");

            


        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topic { get; set; }

    }
}
