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
    public class DeviceMaintenancesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public DeviceMaintenancesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: DeviceMaintenances
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.DeviceMaintenances.Include(d => d.ConfirmUser).Include(d => d.Device).Include(d => d.FunctorUser).Include(d => d.User);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: DeviceMaintenances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceMaintenance = await _context.DeviceMaintenances
                .Include(d => d.ConfirmUser)
                .Include(d => d.Device)
                .Include(d => d.FunctorUser)
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.DeviceMaintenanceID == id);
            if (deviceMaintenance == null)
            {
                return NotFound();
            }

            return View(deviceMaintenance);
        }

        // GET: DeviceMaintenances/Create
        public IActionResult Create()
        {
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName");
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName");
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "NickName");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName");
            return View();
        }

        // POST: DeviceMaintenances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeviceMaintenanceID,DeviceCode,ControlledFactor,DoTime,Result,UserCodeFunctor,UserCodeConfirm,RemediesAndCorrectiveAction,UserCode,UpdateRecordTime,RecordTime")] DeviceMaintenance deviceMaintenance)
        {
            if (ModelState.IsValid)
            {
                deviceMaintenance.UserCode = deviceMaintenance.UserCodeConfirm;
                deviceMaintenance.RecordTime = DateTime.Now;
                deviceMaintenance.UpdateRecordTime = DateTime.Now;
                _context.Add(deviceMaintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCodeConfirm);
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName", deviceMaintenance.DeviceCode);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCodeFunctor);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCode);
            return View(deviceMaintenance);
        }

        // GET: DeviceMaintenances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceMaintenance = await _context.DeviceMaintenances.FindAsync(id);
            if (deviceMaintenance == null)
            {
                return NotFound();
            }
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCodeConfirm);
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName", deviceMaintenance.DeviceCode);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCodeFunctor);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCode);
            return View(deviceMaintenance);
        }

        // POST: DeviceMaintenances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeviceMaintenanceID,DeviceCode,ControlledFactor,DoTime,Result,UserCodeFunctor,UserCodeConfirm,RemediesAndCorrectiveAction,UserCode,UpdateRecordTime,RecordTime")] DeviceMaintenance deviceMaintenance)
        {
            if (id != deviceMaintenance.DeviceMaintenanceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    deviceMaintenance.UpdateRecordTime = DateTime.Now;
                    _context.Update(deviceMaintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeviceMaintenanceExists(deviceMaintenance.DeviceMaintenanceID))
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
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCodeConfirm);
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName", deviceMaintenance.DeviceCode);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCodeFunctor);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", deviceMaintenance.UserCode);
            return View(deviceMaintenance);
        }

        // GET: DeviceMaintenances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deviceMaintenance = await _context.DeviceMaintenances
                .Include(d => d.ConfirmUser)
                .Include(d => d.Device)
                .Include(d => d.FunctorUser)
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.DeviceMaintenanceID == id);
            if (deviceMaintenance == null)
            {
                return NotFound();
            }

            return View(deviceMaintenance);
        }

        // POST: DeviceMaintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deviceMaintenance = await _context.DeviceMaintenances.FindAsync(id);
            _context.DeviceMaintenances.Remove(deviceMaintenance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeviceMaintenanceExists(int id)
        {
            return _context.DeviceMaintenances.Any(e => e.DeviceMaintenanceID == id);
        }
    }
}
