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
    public class WaterBathMaintenancesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public WaterBathMaintenancesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: WaterBathMaintenances
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.WaterBathMaintenance.Include(w => w.Device).Include(w => w.User).Include(w => w.UserConfirm).Include(w => w.UserFunctor);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: WaterBathMaintenances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterBathMaintenance = await _context.WaterBathMaintenance
                .Include(w => w.Device)
                .Include(w => w.User)
                .Include(w => w.UserConfirm)
                .Include(w => w.UserFunctor)
                .FirstOrDefaultAsync(m => m.WaterBathMaintenanceID == id);
            if (waterBathMaintenance == null)
            {
                return NotFound();
            }

            return View(waterBathMaintenance);
        }

        // GET: WaterBathMaintenances/Create
        public IActionResult Create()
        {
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName");
            return View();
        }

        // POST: WaterBathMaintenances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WaterBathMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,Temperatures,WaterExchange,Sedimentation,Clean,UserCodeConfirm,Description,UserCode,UpdateRecordTime,RecordTime")] WaterBathMaintenance waterBathMaintenance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(waterBathMaintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", waterBathMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCodeFunctor);
            return View(waterBathMaintenance);
        }

        // GET: WaterBathMaintenances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterBathMaintenance = await _context.WaterBathMaintenance.FindAsync(id);
            if (waterBathMaintenance == null)
            {
                return NotFound();
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", waterBathMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCodeFunctor);
            return View(waterBathMaintenance);
        }

        // POST: WaterBathMaintenances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WaterBathMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,Temperatures,WaterExchange,Sedimentation,Clean,UserCodeConfirm,Description,UserCode,UpdateRecordTime,RecordTime")] WaterBathMaintenance waterBathMaintenance)
        {
            if (id != waterBathMaintenance.WaterBathMaintenanceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(waterBathMaintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WaterBathMaintenanceExists(waterBathMaintenance.WaterBathMaintenanceID))
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
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", waterBathMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", waterBathMaintenance.UserCodeFunctor);
            return View(waterBathMaintenance);
        }

        // GET: WaterBathMaintenances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterBathMaintenance = await _context.WaterBathMaintenance
                .Include(w => w.Device)
                .Include(w => w.User)
                .Include(w => w.UserConfirm)
                .Include(w => w.UserFunctor)
                .FirstOrDefaultAsync(m => m.WaterBathMaintenanceID == id);
            if (waterBathMaintenance == null)
            {
                return NotFound();
            }

            return View(waterBathMaintenance);
        }

        // POST: WaterBathMaintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var waterBathMaintenance = await _context.WaterBathMaintenance.FindAsync(id);
            _context.WaterBathMaintenance.Remove(waterBathMaintenance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WaterBathMaintenanceExists(int id)
        {
            return _context.WaterBathMaintenance.Any(e => e.WaterBathMaintenanceID == id);
        }
    }
}
