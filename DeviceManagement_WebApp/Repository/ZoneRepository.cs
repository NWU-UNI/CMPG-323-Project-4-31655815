using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        void IZoneRepository.Remove(Task<Zone> zone)
        {
            throw new NotImplementedException();
        }
    }




}
