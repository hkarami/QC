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
    public class LogBookDevicesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public LogBookDevicesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: LogBookDevices
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.LogBookDevices.Include(l => l.Device).Include(l => l.User).Include(l => l.deviceStatus);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: LogBookDevices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logBookDevice = await _context.LogBookDevices
                .Include(l => l.Device)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.IdLogBook == id);
            if (logBookDevice == null)
            {
                return NotFound();
            }

            return View(logBookDevice);
        }

        // GET: LogBookDevices/Create
        public IActionResult Create()
        {
            
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName");
            ViewData["DeviceStatusID"] = new SelectList(_context.DeviceStatuses.OrderBy(o => o.InOrder), "DeviceStatusID", "DeviceStatusName");
            return View();
        }

        // POST: LogBookDevices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLogBook,DeviceCode,UserCode,DoTime,StartTime,EndTime,DeviceStatusID,Description,RecordTime")] LogBookDevice logBookDevice)
        {
            if (ModelState.IsValid)
            {
                logBookDevice.RecordTime = DateTime.Now;
                _context.Add(logBookDevice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName", logBookDevice.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", logBookDevice.UserCode);
            ViewData["DeviceStatusID"] = new SelectList(_context.DeviceStatuses.OrderBy(o => o.InOrder), "DeviceStatusID", "DeviceStatusName",logBookDevice.DeviceStatusID);
            return View(logBookDevice);
        }

        // GET: LogBookDevices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logBookDevice = await _context.LogBookDevices.FindAsync(id);
            if (logBookDevice == null)
            {
                return NotFound();
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName", logBookDevice.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", logBookDevice.UserCode);
            ViewData["DeviceStatusID"] = new SelectList(_context.DeviceStatuses.OrderBy(o => o.InOrder), "DeviceStatusID", "DeviceStatusName",logBookDevice.DeviceStatusID);
            return View(logBookDevice);
        }

        // POST: LogBookDevices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLogBook,DeviceCode,UserCode,DoTime,StartTime,EndTime,DeviceStatusID,Description,RecordTime")] LogBookDevice logBookDevice)
        {
            if (id != logBookDevice.IdLogBook)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(logBookDevice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LogBookDeviceExists(logBookDevice.IdLogBook))
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
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName", logBookDevice.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", logBookDevice.UserCode);
            ViewData["DeviceStatusID"] = new SelectList(_context.DeviceStatuses.OrderBy(o => o.InOrder), "DeviceStatusID", "DeviceStatusName",logBookDevice.DeviceStatusID);
            return View(logBookDevice);
        }

        // GET: LogBookDevices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logBookDevice = await _context.LogBookDevices
                .Include(l => l.Device)
                .Include(l => l.User)
                .Include(l=>l.deviceStatus)
                .FirstOrDefaultAsync(m => m.IdLogBook == id);
            if (logBookDevice == null)
            {
                return NotFound();
            }

            return View(logBookDevice);
        }

        // POST: LogBookDevices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var logBookDevice = await _context.LogBookDevices.FindAsync(id);
            _context.LogBookDevices.Remove(logBookDevice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LogBookDeviceExists(int id)
        {
            return _context.LogBookDevices.Any(e => e.IdLogBook == id);
        }
    }
}
