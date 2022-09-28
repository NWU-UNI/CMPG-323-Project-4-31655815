using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        void Add(Models.Zone zone);


        //Task FindAsyncVal(Guid? id);
        //Task FindAsyncVal(Guid? id);
        //Task<object> ToListAsync();
        void Remove(Task<Zone> zone);
        void Update(Models.Zone zone);
    }




}
