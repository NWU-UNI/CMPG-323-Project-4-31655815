using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        Zone GetMostRecentZone();
    }

    


}
