using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {

        //void Add(Models.Device device);

        //Task<object> ToListAsync();
        //void Update(Models.Device device);

        //Task<object> ToListAsync();
        IEnumerable Category { get; }
        IEnumerable Zone { get; }
    }
}
