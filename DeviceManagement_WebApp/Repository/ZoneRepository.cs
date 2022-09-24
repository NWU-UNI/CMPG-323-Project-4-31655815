using DeviceManagement_WebApp.Data;
using Microsoft.EntityFrameworkCore;
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
            //return DbContext.Zone.OrderByDescending(Zone => Zone.CreatedDate).FirstOrDefault();
        }
    }




}
