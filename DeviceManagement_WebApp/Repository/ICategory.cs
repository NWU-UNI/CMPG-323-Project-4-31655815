using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategory : IGenericRepository<Category>
    {
        object Category { get; }

        bool Any(Func<object, bool> value);
        Task FindAsync(Guid? id);
        IActionResult FindAsync();
        object FindAsync(Func<object, bool> value);
        Task FirstOrDefaultAsync(Func<object, bool> value);
        Category GetMostRecentCategory();
        void Remove(Task category);
        Task SaveChangesAsync();
        Task<object> ToListAsync();
    }
}
