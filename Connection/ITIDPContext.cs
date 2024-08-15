using EF_Core_1.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.Connection
{
    internal class ITIDPContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = OMARMAGDY ; DataBase = ITI ; Trusted_Connection = true ; Encrypt = False");
        }
        public DbSet<Topic> topics { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }
        public DbSet<Stud_Course> stud_courses { get;set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Stud_Course>().HasKey(s=>s.StudId);
           modelBuilder.Entity<Course_Inst>().HasKey(c=>c.InstId);
        }
    }
}
