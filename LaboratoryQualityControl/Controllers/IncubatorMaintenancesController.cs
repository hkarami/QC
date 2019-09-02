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
    public class IncubatorMaintenancesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public IncubatorMaintenancesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: IncubatorMaintenances
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.incubatorMaintenances.Include(i => i.Device).Include(i => i.User).Include(i => i.UserConfirm).Include(i => i.UserFunctor);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: IncubatorMaintenances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incubatorMaintenance = await _context.incubatorMaintenances
                .Include(i => i.Device)
                .Include(i => i.User)
                .Include(i => i.UserConfirm)
                .Include(i => i.UserFunctor)
                .FirstOrDefaultAsync(m => m.IncubatorMaintenanceID == id);
            if (incubatorMaintenance == null)
            {
                return NotFound();
            }

            return View(incubatorMaintenance);
        }

        // GET: IncubatorMaintenances/Create
        public IActionResult Create()
        {
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName");
            return View();
        }

        // POST: IncubatorMaintenances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncubatorMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,Temperatures8,Temperatures16,Clean,Description,UserCodeConfirm,UserCode,UpdateRecordTime,RecordTime")] IncubatorMaintenance incubatorMaintenance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incubatorMaintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", incubatorMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCodeFunctor);
            return View(incubatorMaintenance);
        }

        // GET: IncubatorMaintenances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incubatorMaintenance = await _context.incubatorMaintenances.FindAsync(id);
            if (incubatorMaintenance == null)
            {
                return NotFound();
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", incubatorMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCodeFunctor);
            return View(incubatorMaintenance);
        }

        // POST: IncubatorMaintenances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncubatorMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,Temperatures8,Temperatures16,Clean,Description,UserCodeConfirm,UserCode,UpdateRecordTime,RecordTime")] IncubatorMaintenance incubatorMaintenance)
        {
            if (id != incubatorMaintenance.IncubatorMaintenanceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incubatorMaintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncubatorMaintenanceExists(incubatorMaintenance.IncubatorMaintenanceID))
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
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", incubatorMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", incubatorMaintenance.UserCodeFunctor);
            return View(incubatorMaintenance);
        }

        // GET: IncubatorMaintenances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incubatorMaintenance = await _context.incubatorMaintenances
                .Include(i => i.Device)
                .Include(i => i.User)
                .Include(i => i.UserConfirm)
                .Include(i => i.UserFunctor)
                .FirstOrDefaultAsync(m => m.IncubatorMaintenanceID == id);
            if (incubatorMaintenance == null)
            {
                return NotFound();
            }

            return View(incubatorMaintenance);
        }

        // POST: IncubatorMaintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incubatorMaintenance = await _context.incubatorMaintenances.FindAsync(id);
            _context.incubatorMaintenances.Remove(incubatorMaintenance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncubatorMaintenanceExists(int id)
        {
            return _context.incubatorMaintenances.Any(e => e.IncubatorMaintenanceID == id);
        }
    }
}
