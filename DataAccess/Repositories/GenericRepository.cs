using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        public void Add(T entity)
        {
            using var c = new NTierArchitectureContext();
            c.Add(entity);
            c.SaveChanges();

        }

        public void Delete(T entity)
        {
            using var c = new NTierArchitectureContext();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new NTierArchitectureContext();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new NTierArchitectureContext();
            return c.Set<T>().Find(id);

        }

        public void Update(T entity)
        {
            using var c = new NTierArchitectureContext();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
