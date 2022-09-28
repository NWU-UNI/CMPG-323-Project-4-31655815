using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategory : IGenericRepository<Category>
    {

        Task FirstOrDefaultAsync(Guid? id);
        void Remove(Task<Category> category);

        //Task FindAsync(Guid? id);
        //object FindAsync(Func<object, bool> value);

    }
}
