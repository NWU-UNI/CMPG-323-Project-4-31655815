using DeviceManagement_WebApp.Models;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategory : IGenericRepository<Category>
    {
        bool Any(Func<object, bool> value);
        Task FindAsync(Guid? id);
        Category GetMostRecentCategory();
        void Remove(Task category);
        Task SaveChangesAsync();
        Task<object> ToListAsync();
    }
}
