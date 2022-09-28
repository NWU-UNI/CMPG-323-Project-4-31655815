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




    }


}
