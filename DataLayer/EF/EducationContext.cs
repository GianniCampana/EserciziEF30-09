using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DataLayer.EF
{
    public class EducationContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=Education; User Id=sa; Password=1Secure*Password;")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name, DbLoggerCategory.Database.Transaction.Name },
                 LogLevel.Information).EnableSensitiveDataLogging(); 
        }
    }
}
