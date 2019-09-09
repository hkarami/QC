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
    public class SpectrophotometerMaintenancesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public SpectrophotometerMaintenancesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: SpectrophotometerMaintenances
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.SpectrophotometerMaintenances.Include(s => s.Device).Include(s => s.User).Include(s => s.UserConfirm).Include(s => s.UserFunctor);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: SpectrophotometerMaintenances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spectrophotometerMaintenance = await _context.SpectrophotometerMaintenances
                .Include(s => s.Device)
                .Include(s => s.User)
                .Include(s => s.UserConfirm)
                .Include(s => s.UserFunctor)
                .FirstOrDefaultAsync(m => m.SpectrophotometerMaintenanceID == id);
            if (spectrophotometerMaintenance == null)
            {
                return NotFound();
            }

            return View(spectrophotometerMaintenance);
        }

        // GET: SpectrophotometerMaintenances/Create
        public IActionResult Create()
        {
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName");
            return View();
        }

        // POST: SpectrophotometerMaintenances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpectrophotometerMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,SetDeviceZero,LightBulbClean,BulbReplacement,MirrorSwitch,MirrorClean,MirrorAdjustment,Description,UserCodeConfirm,UserCode,UpdateRecordTime,RecordTime")] SpectrophotometerMaintenance spectrophotometerMaintenance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spectrophotometerMaintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", spectrophotometerMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCodeFunctor);
            return View(spectrophotometerMaintenance);
        }

        // GET: SpectrophotometerMaintenances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spectrophotometerMaintenance = await _context.SpectrophotometerMaintenances.FindAsync(id);
            if (spectrophotometerMaintenance == null)
            {
                return NotFound();
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", spectrophotometerMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCodeFunctor);
            return View(spectrophotometerMaintenance);
        }

        // POST: SpectrophotometerMaintenances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpectrophotometerMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,SetDeviceZero,LightBulbClean,BulbReplacement,MirrorSwitch,MirrorClean,MirrorAdjustment,Description,UserCodeConfirm,UserCode,UpdateRecordTime,RecordTime")] SpectrophotometerMaintenance spectrophotometerMaintenance)
        {
            if (id != spectrophotometerMaintenance.SpectrophotometerMaintenanceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spectrophotometerMaintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpectrophotometerMaintenanceExists(spectrophotometerMaintenance.SpectrophotometerMaintenanceID))
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
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", spectrophotometerMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", spectrophotometerMaintenance.UserCodeFunctor);
            return View(spectrophotometerMaintenance);
        }

        // GET: SpectrophotometerMaintenances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spectrophotometerMaintenance = await _context.SpectrophotometerMaintenances
                .Include(s => s.Device)
                .Include(s => s.User)
                .Include(s => s.UserConfirm)
                .Include(s => s.UserFunctor)
                .FirstOrDefaultAsync(m => m.SpectrophotometerMaintenanceID == id);
            if (spectrophotometerMaintenance == null)
            {
                return NotFound();
            }

            return View(spectrophotometerMaintenance);
        }

        // POST: SpectrophotometerMaintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spectrophotometerMaintenance = await _context.SpectrophotometerMaintenances.FindAsync(id);
            _context.SpectrophotometerMaintenances.Remove(spectrophotometerMaintenance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpectrophotometerMaintenanceExists(int id)
        {
            return _context.SpectrophotometerMaintenances.Any(e => e.SpectrophotometerMaintenanceID == id);
        }
    }
}
