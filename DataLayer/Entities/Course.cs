using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Course
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int HourDuration { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long ClassroomId { get; set; }
        public Classroom  Classroom { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();
    }
}
