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
    public class ServiceDevicesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public ServiceDevicesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: ServiceDevices
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.serviceDevices.Include(s => s.LocationService).Include(s => s.User);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: ServiceDevices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDevice = await _context.serviceDevices
                .Include(s => s.LocationService)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ServiceDeviceID == id);
            if (serviceDevice == null)
            {
                return NotFound();
            }

            return View(serviceDevice);
        }

        // GET: ServiceDevices/Create
        public IActionResult Create()
        {
            ViewData["LocationServiceID"] = new SelectList(_context.locationServices, "LocationServiceID", "LocationServiceName");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName");
            return View();
        }

        // POST: ServiceDevices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceDeviceID,ExitTimeOfWork,UserCode,ContactTimeForSupportCompany,UserCodeDisinfectantDevice,ServiceTime,SupportCompanyName,ServiceMenName,LocationServiceID,DescriptionOfRepairCompleted,TimeReturnToWork,TechnicalApproval,Description,RecordTime")] ServiceDevice serviceDevice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceDevice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationServiceID"] = new SelectList(_context.locationServices, "LocationServiceID", "LocationServiceName", serviceDevice.LocationServiceID);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", serviceDevice.UserCode);
            return View(serviceDevice);
        }

        // GET: ServiceDevices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDevice = await _context.serviceDevices.FindAsync(id);
            if (serviceDevice == null)
            {
                return NotFound();
            }
            ViewData["LocationServiceID"] = new SelectList(_context.locationServices, "LocationServiceID", "LocationServiceName", serviceDevice.LocationServiceID);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", serviceDevice.UserCode);
            return View(serviceDevice);
        }

        // POST: ServiceDevices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServiceDeviceID,ExitTimeOfWork,UserCode,ContactTimeForSupportCompany,UserCodeDisinfectantDevice,ServiceTime,SupportCompanyName,ServiceMenName,LocationServiceID,DescriptionOfRepairCompleted,TimeReturnToWork,TechnicalApproval,Description,RecordTime")] ServiceDevice serviceDevice)
        {
            if (id != serviceDevice.ServiceDeviceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceDevice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceDeviceExists(serviceDevice.ServiceDeviceID))
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
            ViewData["LocationServiceID"] = new SelectList(_context.locationServices, "LocationServiceID", "LocationServiceName", serviceDevice.LocationServiceID);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", serviceDevice.UserCode);
            return View(serviceDevice);
        }

        // GET: ServiceDevices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDevice = await _context.serviceDevices
                .Include(s => s.LocationService)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ServiceDeviceID == id);
            if (serviceDevice == null)
            {
                return NotFound();
            }

            return View(serviceDevice);
        }

        // POST: ServiceDevices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceDevice = await _context.serviceDevices.FindAsync(id);
            _context.serviceDevices.Remove(serviceDevice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceDeviceExists(int id)
        {
            return _context.serviceDevices.Any(e => e.ServiceDeviceID == id);
        }
    }
}
