using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IStudentRepository : ICrudRepository<Student, long>
    {
        IEnumerable<Student> FindByLastnameLike(string part);
    }
}
