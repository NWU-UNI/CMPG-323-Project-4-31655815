using DeviceManagement_WebApp.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections;

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

        public IEnumerable Category => _context.Category;

        public IEnumerable Zone => _context.Zone;

        public Task<T> FindAsyncVal(Guid? id)
        {
            return _context.FindAsync(id);
        }


        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
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

 

        Task IGenericRepository<T>.SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public bool ZoneExists(Guid? id)
        {
            return _context.ZoneExists(id);
        }

        public void Add(Models.Zone zone)
        {
            _context.Add(zone);
        }

        public void Remove(Task<Zone> zone)
        {
            _context.Remove(zone);
        }

        public void Update(Models.Zone zone)
        {
            _context.Update(zone);
        }

        public object Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}


