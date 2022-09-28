using DeviceManagement_WebApp.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement_WebApp.Repository
{
    public class GenericRepository<T> : IGenericRepository <T> where T : class
    {
        protected readonly ConnectedOfficeContext _context;
        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }


        public ValueTask<T> FindAsyncVal(Guid? id)
        {
            return _context.Set<T>().FindAsync(id);
        }


        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync(id);
        }


        void IGenericRepository<T>.Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void FirstOrDefaultAsync(int id)
        {
            _context.Set<T>().FirstOrDefaultAsync(id);
        }


        public Task<object> ToListAsync()
        {
            return _context.ToListAsync();
        }


        bool IGenericRepository<T>.Any(Guid id)
        {
           return _context.Set<T>().Any(id);
        }


    }
}


