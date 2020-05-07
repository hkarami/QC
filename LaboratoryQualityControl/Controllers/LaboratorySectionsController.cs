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
    public class LaboratorySectionsController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public LaboratorySectionsController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: LaboratorySections
        public async Task<IActionResult> Index()
        {
            return View(await _context.LaboratorySections.ToListAsync());
        }

        // GET: LaboratorySections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratorySections = await _context.LaboratorySections
                .FirstOrDefaultAsync(m => m.SectionCodeLab == id);
            if (laboratorySections == null)
            {
                return NotFound();
            }

            return View(laboratorySections);
        }

        // GET: LaboratorySections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LaboratorySections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SectionCodeLab,SectionNameLab,InOrder,RecordTime")] LaboratorySection laboratorySections)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laboratorySections);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laboratorySections);
        }

        // GET: LaboratorySections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratorySections = await _context.LaboratorySections.FindAsync(id);
            if (laboratorySections == null)
            {
                return NotFound();
            }
            return View(laboratorySections);
        }

        // POST: LaboratorySections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SectionCodeLab,SectionNameLab,InOrder,RecordTime")] LaboratorySection laboratorySections)
        {
            if (id != laboratorySections.SectionCodeLab)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laboratorySections);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaboratorySectionsExists(laboratorySections.SectionCodeLab))
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
            return View(laboratorySections);
        }

        // GET: LaboratorySections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratorySections = await _context.LaboratorySections
                .FirstOrDefaultAsync(m => m.SectionCodeLab == id);
            if (laboratorySections == null)
            {
                return NotFound();
            }

            return View(laboratorySections);
        }

        // POST: LaboratorySections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laboratorySections = await _context.LaboratorySections.FindAsync(id);
            _context.LaboratorySections.Remove(laboratorySections);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratorySectionsExists(int id)
        {
            return _context.LaboratorySections.Any(e => e.SectionCodeLab == id);
        }
    }
}
