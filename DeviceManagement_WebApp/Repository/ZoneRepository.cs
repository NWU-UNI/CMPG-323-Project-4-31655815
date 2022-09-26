using DeviceManagement_WebApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Policy;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        Zone IZoneRepository.GetMostRecentZone()
        {
            throw new System.NotImplementedException();
            //return _context.Zone.OrderByDescending(Zone => Zone.CreatedDate).FirstOrDefault();
        }

        
    }




}
