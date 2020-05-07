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
    public class DevicesController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public DevicesController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: Devices
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.Devices.Include(d => d.LaboratorySections).Include(d=>d.DeviceType).Include(d=>d.User);
            return View(await laboratoryQCContext.ToListAsync());
            //return View();
        }

        // GET: Devices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = await _context.Devices
                .Include(d => d.LaboratorySections)
                .FirstOrDefaultAsync(m => m.DeviceCode == id);
            if (device == null)
            {
                return NotFound();
            }

            return View(device);
        }

        // GET: Devices/Create
        public IActionResult Create()
        {
            ViewData["SectionNameLab"] = new SelectList(_context.LaboratorySections.OrderBy(o=>o.InOrder), "SectionCodeLab", "SectionNameLab");
            ViewData["DeviceTypeName"] = new SelectList(_context.DeviceTypes.OrderBy(o => o.InOrder), "DeviceTypeID", "DeviceTypeName");
            ViewData["Users"] = new SelectList(_context.User, "UserCode", "NickName");
            return View();
        }

        // POST: Devices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeviceCode,DeviceName,DeviceTypeID,Factory,Model,ManufacturingCountry,SerialNumber,SupportCompany,Location,FeaturedUsers,IdentificationCode,DateSubmittedToLab,SectionLaunchDATE,DeliveryStatus,SpecialCharacteristic,RelatedEquipment,PhoneToSupportCompany,SectionCodeLab,Other,UserCode,UpdateRecordTime,RecordTime")] Device device)
        {
            if (ModelState.IsValid)
            {
                device.RecordTime = DateTime.Now;
                device.UpdateRecordTime = DateTime.Now;
                _context.Add(device);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["SectionCodeLab"] = new SelectList(_context.LaboratorySections, "SectionCodeLab", "SectionCodeLab", device.SectionCodeLab);
            ViewData["SectionNameLab"] = new SelectList(_context.LaboratorySections.OrderBy(o => o.InOrder), "SectionCodeLab", "SectionNameLab",device.SectionCodeLab);
            ViewData["DeviceTypeName"] = new SelectList(_context.DeviceTypes.OrderBy(o => o.InOrder), "DeviceTypeID", "DeviceTypeName",device.DeviceTypeId);
            ViewData["Users"] = new SelectList(_context.User, "UserCode", "NickName",device.UserCode);
            return View(device);
        }

        // GET: Devices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = await _context.Devices.FindAsync(id);
            if (device == null)
            {
                return NotFound();
            }
            ViewData["SectionNameLab"] = new SelectList(_context.LaboratorySections.OrderBy(o => o.InOrder), "SectionCodeLab", "SectionNameLab", device.SectionCodeLab);
            ViewData["DeviceTypeName"] = new SelectList(_context.DeviceTypes.OrderBy(o => o.InOrder), "DeviceTypeID", "DeviceTypeName", device.DeviceTypeId);
            ViewData["Users"] = new SelectList(_context.User, "UserCode", "NickName", device.UserCode);
            return View(device);
        }

        // POST: Devices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeviceCode,DeviceName,DeviceTypeID,Factory,Model,ManufacturingCountry,SerialNumber,SupportCompany,Location,FeaturedUsers,IdentificationCode,DateSubmittedToLab,SectionLaunchDATE,DeliveryStatus,SpecialCharacteristic,RelatedEquipment,PhoneToSupportCompany,SectionCodeLab,Other,UserCode,UpdateRecordTime,RecordTime")] Device device)
        {
            if (id != device.DeviceCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    device.UpdateRecordTime = DateTime.Now;
                    _context.Update(device);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeviceExists(device.DeviceCode))
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
            //ViewData["SectionCodeLab"] = new SelectList(_context.LaboratorySections, "SectionCodeLab", "SectionCodeLab", device.SectionCodeLab);
            ViewData["SectionNameLab"] = new SelectList(_context.LaboratorySections.OrderBy(o => o.InOrder), "SectionCodeLab", "SectionNameLab", device.SectionCodeLab);
            ViewData["DeviceTypeName"] = new SelectList(_context.DeviceTypes.OrderBy(o => o.InOrder), "DeviceTypeID", "DeviceTypeName", device.DeviceTypeId);
            ViewData["Users"] = new SelectList(_context.User, "UserCode", "NickName", device.UserCode);
            return View(device);
        }

        // GET: Devices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = await _context.Devices
                .Include(d => d.LaboratorySections)
                .FirstOrDefaultAsync(m => m.DeviceCode == id);
            if (device == null)
            {
                return NotFound();
            }

            return View(device);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var device = await _context.Devices.FindAsync(id);
            _context.Devices.Remove(device);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeviceExists(int id)
        {
            return _context.Devices.Any(e => e.DeviceCode == id);
        }
    }
}
