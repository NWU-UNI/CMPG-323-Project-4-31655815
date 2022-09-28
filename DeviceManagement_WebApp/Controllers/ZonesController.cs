using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DeviceManagement_WebApp.Controllers
{
    public class ZonesController : Controller
    {

        private readonly IZoneRepository _ZoneRepository;


        public ZonesController(IZoneRepository zoneRepository)
        {
            _ZoneRepository = zoneRepository;
        }


    

        // GET: Zones
        public async Task<IActionResult> Index()
        {
            //return View(await _ZoneRepository.GetAll());
            return View(await _ZoneRepository.ToListAsync());
        }

       // GET: Zones/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zone = await _ZoneRepository.FindAsyncVal(id);
            if (zone == null)
            {
                return NotFound();
            }

            return View(zone);
        }

        // GET: Zones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZoneId,ZoneName,ZoneDescription,DateCreated")] Zone zone)
        {
            zone.ZoneId = Guid.NewGuid();
            _ZoneRepository.Add(zone);
            await _ZoneRepository.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Zones/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zone = await _ZoneRepository.FindAsyncVal(id);
            if (zone == null)
            {
                return NotFound();
            }
            return View(zone);
        }

        // POST: Zones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
         public Task<IActionResult> Edit(Guid id, [Bind("ZoneId,ZoneName,ZoneDescription,DateCreated")] Zone zone)
        {
            if (id != zone.ZoneId)
            {
                return FromResult(NotFound());
           }

            try
            {
                _ZoneRepository.Update(zone);
                _ZoneRepository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZoneExists(zone.ZoneId))
                {
                    return FromResult(NotFound());
               }
                else
                {
                    throw;
                }
            }
            return FromResult(RedirectToAction(nameof(Index)));

        }

        private Task<IActionResult> FromResult(RedirectToActionResult redirectToActionResult)
        {
            throw new NotImplementedException();
        }

        private Task<IActionResult> FromResult(NotFoundResult notFoundResult)
        {
            throw new NotImplementedException();
        }

        // GET: Zones/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zone = await _ZoneRepository.FindAsyncVal(id);
            if (zone == null)
            {
                return NotFound();
            }

            return View(zone);
        }

        // POST: Zones/Delete/5
        [HttpPost, ActionName("Delete")]
        
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var zone = _ZoneRepository.FindAsyncVal(id);
            _ZoneRepository.Remove(zone);
            await _ZoneRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZoneExists(Guid id)
        {
            return _ZoneRepository.Any(id);
        }
    }
}
