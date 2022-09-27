using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Task FirstOrDefaultAsync(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public Device  GetMostRecentDevice()
        {
            //throw new System.NotImplementedException();
            return _context.Device.OrderByDescending(Device => Device.DateCreated).FirstOrDefault();
        }

        public void Remove(Task device)
        {
            throw new NotImplementedException();
        }

        public Task<object> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Device device)
        {
            throw new NotImplementedException();
        }

        Task IDeviceRepository.FindAsyncVal(Guid? id)
        {
            throw new NotImplementedException();
        }

        object IDeviceRepository.Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        Task IDeviceRepository.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }


}
