using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Internals;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MediaDBContext mediaContext;
        public DbSet<T> Table { get;}

        public Repository(MediaDBContext mediaDBContext)
        {
            mediaContext = mediaDBContext;
            Table = mediaContext.Set<T>();
        }
        public void Add(T entity)
        {
            mediaContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return mediaContext.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return mediaContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAllObj()
        {
            return mediaContext.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            mediaContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
