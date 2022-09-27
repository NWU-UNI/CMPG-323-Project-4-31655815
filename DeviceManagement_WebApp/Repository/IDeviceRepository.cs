using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        IEnumerable Category { get; }
        IEnumerable Zone { get; set; }

        Device GetMostRecentDevice();

        //void Add(Models.Device device);
        Task FindAsyncVal(Guid? id);
        Task FirstOrDefaultAsync(Func<object, bool> value);
        void Remove(Task device);
        Task SaveChangesAsync();
        Task<object> ToListAsync();
        //void Update(Models.Device device);
        object Include(Func<object, object> value);
        Task FindAsync(Guid id);
        bool Any(Func<object, bool> value);
        Task FindAsync(Guid? id);
    }
}
