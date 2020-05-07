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
            var laboratoryQCContext = _context.ServiceDevices.Include(s => s.LocationService)
                                                             .Include(s => s.User)
                                                             .Include(s => s.Device)
                                                             .Include(s => s.ConfirmUser)
                                                             .Include(s => s.UserDisinfectantDevice)
                                                             .Include(s => s.SupportCompany);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: ServiceDevices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDevice = await _context.ServiceDevices
                .Include(s => s.LocationService)
                .Include(s => s.User)
                .Include(s => s.Device)
                .Include(s => s.ConfirmUser)
                .Include(s => s.UserDisinfectantDevice)
                .Include(s => s.SupportCompany)
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
            ViewData["LocationServiceID"] = new SelectList(_context.LocationServices.Where(w=>w.Visible==true).OrderBy(o=>o.InOrder), "LocationServiceID", "LocationServiceName");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName");
            ViewData["UserCodeDisinfectantDevice"]= new SelectList(_context.User, "UserCode", "NickName");
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName");
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName");
            ViewData["SupportCompanyID"] = new SelectList(_context.SupportCompanies.Where(w => w.Visible == true).OrderBy(o => o.InOrder), "SupportCompanyID", "SupportCompanyName");
            return View();
        }

        // POST: ServiceDevices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceDeviceID,DeviceCode,ExitTimeOfWork,UserCode,ContactTimeForSupportCompany,UserCodeDisinfectantDevice,ServiceTime,SupportCompanyID,ServiceMenName,LocationServiceID,DescriptionOfRepairCompleted,TimeReturnToWork,UserCodeConfirm,Description,RecordTime")] ServiceDevice serviceDevice)
        {
            if (ModelState.IsValid)
            {
                serviceDevice.UserCode = serviceDevice.UserCodeConfirm;
                serviceDevice.RecordTime = DateTime.Now;
                _context.Add(serviceDevice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationServiceID"] = new SelectList(_context.LocationServices, "LocationServiceID", "LocationServiceName", serviceDevice.LocationServiceID);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCode);
            ViewData["UserCodeDisinfectantDevice"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCodeDisinfectantDevice);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCodeConfirm);
            ViewData["SupportCompanyID"] = new SelectList(_context.SupportCompanies.Where(w => w.Visible == true).OrderBy(o => o.InOrder), "SupportCompanyID", "SupportCompanyName",serviceDevice.SupportCompanyID);
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName",serviceDevice.DeviceCode);
            return View(serviceDevice);
        }

        // GET: ServiceDevices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDevice = await _context.ServiceDevices.FindAsync(id);
            if (serviceDevice == null)
            {
                return NotFound();
            }
            ViewData["LocationServiceID"] = new SelectList(_context.LocationServices, "LocationServiceID", "LocationServiceName", serviceDevice.LocationServiceID);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCode);
            ViewData["UserCodeDisinfectantDevice"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCodeDisinfectantDevice);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCodeConfirm);
            ViewData["SupportCompanyID"] = new SelectList(_context.SupportCompanies.Where(w => w.Visible == true).OrderBy(o => o.InOrder), "SupportCompanyID", "SupportCompanyName", serviceDevice.SupportCompanyID);
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName",serviceDevice.DeviceCode);
            return View(serviceDevice);
        }

        // POST: ServiceDevices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServiceDeviceID,DeviceCode,ExitTimeOfWork,UserCode,ContactTimeForSupportCompany,UserCodeDisinfectantDevice,ServiceTime,SupportCompanyID,ServiceMenName,LocationServiceID,DescriptionOfRepairCompleted,TimeReturnToWork,UserCodeConfirm,Description,RecordTime")] ServiceDevice serviceDevice)
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
            ViewData["LocationServiceID"] = new SelectList(_context.LocationServices, "LocationServiceID", "LocationServiceName", serviceDevice.LocationServiceID);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCode);
            ViewData["UserCodeDisinfectantDevice"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCodeDisinfectantDevice);
            ViewData["UserCodeConfirm"] = new SelectList(_context.User, "UserCode", "NickName", serviceDevice.UserCodeConfirm);
            ViewData["SupportCompanyID"] = new SelectList(_context.SupportCompanies.Where(w => w.Visible == true).OrderBy(o => o.InOrder), "SupportCompanyID", "SupportCompanyName", serviceDevice.SupportCompanyID);
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceName",serviceDevice.DeviceCode);
            return View(serviceDevice);
        }

        // GET: ServiceDevices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDevice = await _context.ServiceDevices
                .Include(s => s.LocationService)
                .Include(s => s.User)
                .Include(s => s.Device)
                .Include(s => s.SupportCompany)
                .Include(s => s.ConfirmUser)
                .Include(s=>s.UserDisinfectantDevice)
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
            var serviceDevice = await _context.ServiceDevices.FindAsync(id);
            _context.ServiceDevices.Remove(serviceDevice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceDeviceExists(int id)
        {
            return _context.ServiceDevices.Any(e => e.ServiceDeviceID == id);
        }
    }
}
