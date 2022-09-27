using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        void Add(Models.Zone zone);
        Task FindAsyncVal(Guid? id);
        Task FirstOrDefaultAsync(Func<object, bool> value);
        void Remove(Task zone);
        Task SaveChangesAsync();
        Task<object> ToListAsync();
        void Update(Models.Zone zone);
        Zone GetMostRecentZone();
        bool Any(Guid id);
        Task<object> FindAsyncVal();
    }

    


}
