using DataLayer.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class CrudRepository<T, K> : ICrudRepository<T, K> where T : class
    {
        private readonly EducationContext ctx;
        private DbSet<T> entities;
        public CrudRepository(EducationContext ctx)
        {
            this.ctx = ctx;
            this.entities = ctx.Set<T>();
        }
        public T Create(T newElement)
        {
            entities.Add(newElement);
            ctx.SaveChanges();
            return newElement;
        }

        public T Delete(K id)
        {
            T found = entities.Find(id);
            if(found == null)
            {
                return null;
            }
            entities.Remove(found);
            ctx.SaveChanges();
            return found;
        }
        public T Delete(T element)
        {
            entities.Remove(element);

            int changes = ctx.SaveChanges();
            if(changes == 0)
            {
                return null;
            }
            return element;
            
        }

        public T FindById(K id)
        {
            return entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Update(T newElement)
        {
            entities.Update(newElement);
            ctx.SaveChanges();
        }
    }
}
