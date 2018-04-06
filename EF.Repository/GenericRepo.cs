using EF.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace EF.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        DbContext context;
        public GenericRepo()
        {
            context = new MyContext();
        }
        public void Add(T t)
        {
            context.Set<T>().Add(t);
        }

        public void Delete(int id)
        {
            var t = GetById(id);
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public Task<List<T>> GetAll()
        {
            return context.Set<T>().ToListAsync();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(int id, T t)
        {
            var t2 = GetById(id);
            t2 = t;
            context.SaveChanges();
        }

        List<T> IGenericRepo<T>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
