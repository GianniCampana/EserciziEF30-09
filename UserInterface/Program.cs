using DataLayer.EF;
using DataLayer.Entities;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom cs = new Classroom() 
            {
                Name = "Turing",
                MaxCapacity = 70,
                IsVirtual = true,
                IsComputerized = true,
            };
            using (var ctx = new EducationContext())
            {
                // Classroom cc = ctx.Classrooms.Find(1L);
                //ctx.Classrooms.Remove(cc);
                //cc.Name = "Neuman";
                //var classrooms = ctx.Classrooms.Where(c => c.Name.StartsWith("Ar") && c.IsComputerized && c.MaxCapacity>60);
                //foreach(var x in classrooms)
                //{
                //    Console.WriteLine(x.Name);
                //}
                //ctx.Classrooms.Add(cs);
                //ctx.SaveChanges();
                //Classroom cc2 = ctx.Classrooms.Find(1L);

                //var s1 = ctx.Students.Include(s => s.Courses).Single(s => s.Id==1);
                //foreach(var c in s1.Courses)
                //{
                //    Console.WriteLine(c.Title);
                //}

                //var s2 = ctx.Students.Find(2L);
                //var c4 = ctx.Courses.Find(4L);

                //s2.Courses.Add(c4);
                //var chimica = new Course() 
                //{
                //    Title = "chimica",
                //    Price = 250,
                //    Description = "bellissimo",
                //    ClassroomId = 2,
                //    HourDuration = 200
                //};
                //s2.Courses.Add(chimica);

                var studente1 = new Student() 
                {
                    Name = "Mario",
                    LastName = "Rossi",
                    Telephone = "3993873654",
                    Address = "via Giuseppe Verdi",
                    Email = "mariorossi@gmail.com"
                };

                //ctx.Students.Update(studente1);
                //ctx.SaveChanges();


                CrudRepository<Student, long> repo = new CrudRepository<Student, long>(ctx);
                var s2 = repo.Create(studente1);
                Console.WriteLine(s2.Id);
                Console.WriteLine(studente1.Id);
            }
        }
    }
}
