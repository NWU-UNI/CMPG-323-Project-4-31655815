using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement_WebApp.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void FirstOrDefaultAsync(int id);
        void Update(T entity);

        Task<T> FindAsyncVal(Guid? id);

        ///void Add(Models.Zone zone);
        //Task FirstOrDefaultAsync(Func<object, bool> value);
        //void Remove(Task zone);
        Task SaveChangesAsync();
 
        Task<object> ToListAsync();
        //void Update(Models.Zone zone);
        bool Any(Guid id);

        //void SaveChangesAsync();
        //void FirstOrDefaultAsync(int id);
        //void Update(T entity);



    }



}