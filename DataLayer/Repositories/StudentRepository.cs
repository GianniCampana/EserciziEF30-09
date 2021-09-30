using DataLayer.EF;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class StudentRepository : CrudRepository<Student, long>, IStudentRepository
    {
        public StudentRepository(EducationContext ctx) : base(ctx)
        {

        }

        public IEnumerable<Student> FindByLastnameLike(string part)
        {
            throw new NotImplementedException();
        }
    }
}
