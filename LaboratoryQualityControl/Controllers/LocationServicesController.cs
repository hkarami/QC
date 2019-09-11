using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Controllers
{
    public class LocationServicesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public LocationServicesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: LocationServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.LocationServices.ToListAsync());
        }

        // GET: LocationServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationService = await _context.LocationServices
                .FirstOrDefaultAsync(m => m.LocationServiceID == id);
            if (locationService == null)
            {
                return NotFound();
            }

            return View(locationService);
        }

        // GET: LocationServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocationServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationServiceID,LocationServiceName,Visible,InOrder,RecordTime")] LocationService locationService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locationService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locationService);
        }

        // GET: LocationServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationService = await _context.LocationServices.FindAsync(id);
            if (locationService == null)
            {
                return NotFound();
            }
            return View(locationService);
        }

        // POST: LocationServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationServiceID,LocationServiceName,Visible,InOrder,RecordTime")] LocationService locationService)
        {
            if (id != locationService.LocationServiceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locationService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationServiceExists(locationService.LocationServiceID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(locationService);
        }

        // GET: LocationServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationService = await _context.LocationServices
                .FirstOrDefaultAsync(m => m.LocationServiceID == id);
            if (locationService == null)
            {
                return NotFound();
            }

            return View(locationService);
        }

        // POST: LocationServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationService = await _context.LocationServices.FindAsync(id);
            _context.LocationServices.Remove(locationService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationServiceExists(int id)
        {
            return _context.LocationServices.Any(e => e.LocationServiceID == id);
        }
    }
}
