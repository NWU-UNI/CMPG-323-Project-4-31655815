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

        public void Add(Models.Zone zone)
        {
            _context.Add(zone);
        }

        public void Remove(Task<Zone> zone)
        {
            _context.Remove(zone);
        }

        public void Update(Models.Zone zone)
        {
            _context.Update(zone);
        }
    }




}
