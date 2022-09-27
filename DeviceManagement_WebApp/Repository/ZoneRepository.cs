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
            throw new NotImplementedException();
        }

        public bool Any(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<object> FindAsyncVal()
        {
            throw new NotImplementedException();
        }

        public Task FirstOrDefaultAsync(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        //private readonly IGenericRepository<Zone> _ZoneRepository;

        public Zone GetMostRecentZone()
        {
            throw new System.NotImplementedException();
            //return _context.Zone.OrderByDescending(Device => Zone.DateCreated).FirstOrDefault();
            
        }

        public void Remove(Task zone)
        {
            throw new NotImplementedException();
        }

        public Task<object> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Models.Zone zone)
        {
            throw new NotImplementedException();
        }

        Task IZoneRepository.FindAsyncVal(Guid? id)
        {
            throw new NotImplementedException();
        }

        Task IZoneRepository.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }




}
