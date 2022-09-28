using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public IEnumerable Category => throw new NotImplementedException();

        public IEnumerable Zone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        IEnumerable IDeviceRepository.Category => throw new NotImplementedException();

        IEnumerable IDeviceRepository.Zone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Any(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public Task FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FindAsync(Guid? id)
        {
            throw new NotImplementedException();
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
            //return _context.ToListAsync();
        }

        public void Update(Device device)
        {
            throw new NotImplementedException();
        }

        bool IDeviceRepository.Any(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        Task IDeviceRepository.FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IDeviceRepository.FindAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        Task IDeviceRepository.FindAsyncVal(Guid? id)
        {
            throw new NotImplementedException();
        }

        Task IDeviceRepository.FirstOrDefaultAsync(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        Device IDeviceRepository.GetMostRecentDevice()
        {
            throw new NotImplementedException();
        }

        object IDeviceRepository.Include(Func<object, object> value)
        {
            throw new NotImplementedException();
            //return _context.Include();
        }

        void IDeviceRepository.Remove(Task device)
        {
            throw new NotImplementedException();
        }

        Task IDeviceRepository.SaveChangesAsync()
        {
            //throw new NotImplementedException();
            return _context.SafeChangesAsync();
        }

        Task<object> IDeviceRepository.ToListAsync()
        {
            throw new NotImplementedException();
        }
    }


}
