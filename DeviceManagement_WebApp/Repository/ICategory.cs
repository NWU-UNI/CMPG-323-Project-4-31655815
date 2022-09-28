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
        //Task FindAsync(Guid? id);
        //object FindAsync(Func<object, bool> value);
        
        Category GetMostRecentCategory();
 
    }
}
