namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
    }
        public ServiceRepository(CMPG323Context context) : base(context)
        {
        }

        public Zone GetMostRecentZone()
        {
            return _context.Zone.OrderByDescending(Zone => Zone.CreatedDate).FirstOrDefault();
        }


    }
