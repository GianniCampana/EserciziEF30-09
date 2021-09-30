using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface ICrudRepository<T,K>
    {
        IEnumerable<T> GetAll();
        T Create(T newElement);
        T Delete(K id);
        T FindById(K id);
        void Update(T newElement);
    }
}
