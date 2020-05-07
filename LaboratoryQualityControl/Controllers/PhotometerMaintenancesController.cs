using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryQualityControl.Controllers
{
    public class PhotometerMaintenancesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public PhotometerMaintenancesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: PhotometerMaintenances
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.PhotometerMaintenances.Include(p => p.Device).Include(p => p.User).Include(p => p.UserConfirm).Include(p => p.UserFunctor);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: PhotometerMaintenances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photometerMaintenance = await _context.PhotometerMaintenances
                .Include(p => p.Device)
                .Include(p => p.User)
                .Include(p => p.UserConfirm)
                .Include(p => p.UserFunctor)
                .FirstOrDefaultAsync(m => m.PhotometerMaintenanceID == id);
            if (photometerMaintenance == null)
            {
                return NotFound();
            }

            return View(photometerMaintenance);
        }

        // GET: PhotometerMaintenances/Create
        public IActionResult Create()
        {
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName");
            return View();
        }

        // POST: PhotometerMaintenances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotometerMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,DeviceWash,GasJunction,PipesAndSuckers,Filter,Glass,Kiln,Chimney,SetDeviceZero,pipeLeaky,ReplaceAnyComponent,DischargeDishesWaste,Compressor,Description,UserCodeConfirm,UserCode,UpdateRecordTime,RecordTime")] PhotometerMaintenance photometerMaintenance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(photometerMaintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", photometerMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCodeFunctor);
            return View(photometerMaintenance);
        }

        // GET: PhotometerMaintenances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photometerMaintenance = await _context.PhotometerMaintenances.FindAsync(id);
            if (photometerMaintenance == null)
            {
                return NotFound();
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", photometerMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCodeFunctor);
            return View(photometerMaintenance);
        }

        // POST: PhotometerMaintenances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotometerMaintenanceID,DeviceCode,DoTime,UserCodeFunctor,DeviceWash,GasJunction,PipesAndSuckers,Filter,Glass,Kiln,Chimney,SetDeviceZero,pipeLeaky,ReplaceAnyComponent,DischargeDishesWaste,Compressor,Description,UserCodeConfirm,UserCode,UpdateRecordTime,RecordTime")] PhotometerMaintenance photometerMaintenance)
        {
            if (id != photometerMaintenance.PhotometerMaintenanceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photometerMaintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotometerMaintenanceExists(photometerMaintenance.PhotometerMaintenanceID))
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
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", photometerMaintenance.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCode);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCodeConfirm);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", photometerMaintenance.UserCodeFunctor);
            return View(photometerMaintenance);
        }

        // GET: PhotometerMaintenances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photometerMaintenance = await _context.PhotometerMaintenances
                .Include(p => p.Device)
                .Include(p => p.User)
                .Include(p => p.UserConfirm)
                .Include(p => p.UserFunctor)
                .FirstOrDefaultAsync(m => m.PhotometerMaintenanceID == id);
            if (photometerMaintenance == null)
            {
                return NotFound();
            }

            return View(photometerMaintenance);
        }

        // POST: PhotometerMaintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photometerMaintenance = await _context.PhotometerMaintenances.FindAsync(id);
            _context.PhotometerMaintenances.Remove(photometerMaintenance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotometerMaintenanceExists(int id)
        {
            return _context.PhotometerMaintenances.Any(e => e.PhotometerMaintenanceID == id);
        }
    }
}
