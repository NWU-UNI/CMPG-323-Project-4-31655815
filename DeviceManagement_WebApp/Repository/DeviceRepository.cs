using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        Zone IDeviceRepository.GetMostRecentDevice()
        {
            throw new System.NotImplementedException();
            //return _context.Device.OrderByDescending(Device => Device.CreatedDate).FirstOrDefault();
        }
    }


}
