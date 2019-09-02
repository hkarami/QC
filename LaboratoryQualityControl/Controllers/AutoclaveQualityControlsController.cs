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
    public class AutoclaveQualityControlsController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public AutoclaveQualityControlsController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: AutoclaveQualityControls
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.autoclaveQualityControls.Include(a => a.Device).Include(a => a.User).Include(a => a.UserFunctor);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: AutoclaveQualityControls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoclaveQualityControl = await _context.autoclaveQualityControls
                .Include(a => a.Device)
                .Include(a => a.User)
                .Include(a => a.UserFunctor)
                .FirstOrDefaultAsync(m => m.AutoclaveQualityControlID == id);
            if (autoclaveQualityControl == null)
            {
                return NotFound();
            }

            return View(autoclaveQualityControl);
        }

        // GET: AutoclaveQualityControls/Create
        public IActionResult Create()
        {
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode");
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName");
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName");
            return View();
        }

        // POST: AutoclaveQualityControls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoclaveQualityControlID,DeviceCode,DoTime,UserCodeFunctor,HeatDuringDeployment,PressureDuringDeployment,PurposeOfUse,ResultTST,ResultBiologic,Description,UserCode,UpdateRecordTime,RecordTime")] AutoclaveQualityControl autoclaveQualityControl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoclaveQualityControl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", autoclaveQualityControl.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", autoclaveQualityControl.UserCode);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", autoclaveQualityControl.UserCodeFunctor);
            return View(autoclaveQualityControl);
        }

        // GET: AutoclaveQualityControls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoclaveQualityControl = await _context.autoclaveQualityControls.FindAsync(id);
            if (autoclaveQualityControl == null)
            {
                return NotFound();
            }
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", autoclaveQualityControl.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", autoclaveQualityControl.UserCode);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", autoclaveQualityControl.UserCodeFunctor);
            return View(autoclaveQualityControl);
        }

        // POST: AutoclaveQualityControls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutoclaveQualityControlID,DeviceCode,DoTime,UserCodeFunctor,HeatDuringDeployment,PressureDuringDeployment,PurposeOfUse,ResultTST,ResultBiologic,Description,UserCode,UpdateRecordTime,RecordTime")] AutoclaveQualityControl autoclaveQualityControl)
        {
            if (id != autoclaveQualityControl.AutoclaveQualityControlID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autoclaveQualityControl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoclaveQualityControlExists(autoclaveQualityControl.AutoclaveQualityControlID))
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
            ViewData["DeviceCode"] = new SelectList(_context.Devices, "DeviceCode", "DeviceCode", autoclaveQualityControl.DeviceCode);
            ViewData["UserCode"] = new SelectList(_context.User, "UserCode", "FName", autoclaveQualityControl.UserCode);
            ViewData["UserCodeFunctor"] = new SelectList(_context.User, "UserCode", "FName", autoclaveQualityControl.UserCodeFunctor);
            return View(autoclaveQualityControl);
        }

        // GET: AutoclaveQualityControls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoclaveQualityControl = await _context.autoclaveQualityControls
                .Include(a => a.Device)
                .Include(a => a.User)
                .Include(a => a.UserFunctor)
                .FirstOrDefaultAsync(m => m.AutoclaveQualityControlID == id);
            if (autoclaveQualityControl == null)
            {
                return NotFound();
            }

            return View(autoclaveQualityControl);
        }

        // POST: AutoclaveQualityControls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autoclaveQualityControl = await _context.autoclaveQualityControls.FindAsync(id);
            _context.autoclaveQualityControls.Remove(autoclaveQualityControl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoclaveQualityControlExists(int id)
        {
            return _context.autoclaveQualityControls.Any(e => e.AutoclaveQualityControlID == id);
        }
    }
}
