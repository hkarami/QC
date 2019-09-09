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
    public class UsersController : Controller
    {
        private readonly LaboratoryQCContext _context;

        public UsersController(LaboratoryQCContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var laboratoryQCContext = _context.User.Include(u => u.BloodType).Include(u => u.EducationalCertificate).Include(u => u.EmploymentStatus).Include(u => u.LaboratorySections).Include(u => u.MaritalStatus).Include(u => u.Role);
            return View(await laboratoryQCContext.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.BloodType)
                .Include(u => u.EducationalCertificate)
                .Include(u => u.EmploymentStatus)
                .Include(u => u.LaboratorySections)
                .Include(u => u.MaritalStatus)
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.UserCode == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            ViewData["BloodTypeID"] = new SelectList(_context.BloodTypes, "BloodTypeID", "BloodTypeName");
            ViewData["EducationalCertificateID"] = new SelectList(_context.EducationalCertificates, "EducationalCertificateId", "EducationalCertificateName");
            ViewData["EmploymentStatusID"] = new SelectList(_context.EmploymentStatuses, "EmploymentStatusID", "EmploymentStatusName");
            ViewData["SectionCodeLab"] = new SelectList(_context.LaboratorySections, "SectionCodeLab", "SectionCodeLab");
            ViewData["MaritalStatusID"] = new SelectList(_context.MaritalStatuses, "MaritalStatusID", "MaritalStatusName");
            ViewData["RoleCode"] = new SelectList(_context.Roles, "RoleCode", "RoleName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserCode,UserName,PassWord,RoleCode,LName,FName,NickName,Sex,BirthDate,ExpireTime,Picture,EnterNum,Email,MaritalStatusID,NumberID,Issued,FatherName,EducationalCertificateID,UniversityName,YearGet,Address,Telephone,TelephoneNecessary,BloodTypeID,DrugSensitivity,BeginTime,SectionCodeLab,EmploymentStatusID,HistoryVaccination,HistoryOfOccupationalInjury,RecordTime")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BloodTypeID"] = new SelectList(_context.BloodTypes, "BloodTypeID", "BloodTypeName", user.BloodTypeID);
            ViewData["EducationalCertificateID"] = new SelectList(_context.EducationalCertificates, "EducationalCertificateId", "EducationalCertificateName", user.EducationalCertificateID);
            ViewData["EmploymentStatusID"] = new SelectList(_context.EmploymentStatuses, "EmploymentStatusID", "EmploymentStatusName", user.EmploymentStatusID);
            ViewData["SectionCodeLab"] = new SelectList(_context.LaboratorySections, "SectionCodeLab", "SectionCodeLab", user.SectionCodeLab);
            ViewData["MaritalStatusID"] = new SelectList(_context.MaritalStatuses, "MaritalStatusID", "MaritalStatusName", user.MaritalStatusID);
            ViewData["RoleCode"] = new SelectList(_context.Roles, "RoleCode", "RoleName", user.RoleCode);
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["BloodTypeID"] = new SelectList(_context.BloodTypes, "BloodTypeID", "BloodTypeName", user.BloodTypeID);
            ViewData["EducationalCertificateID"] = new SelectList(_context.EducationalCertificates, "EducationalCertificateId", "EducationalCertificateName", user.EducationalCertificateID);
            ViewData["EmploymentStatusID"] = new SelectList(_context.EmploymentStatuses, "EmploymentStatusID", "EmploymentStatusName", user.EmploymentStatusID);
            ViewData["SectionCodeLab"] = new SelectList(_context.LaboratorySections, "SectionCodeLab", "SectionCodeLab", user.SectionCodeLab);
            ViewData["MaritalStatusID"] = new SelectList(_context.MaritalStatuses, "MaritalStatusID", "MaritalStatusName", user.MaritalStatusID);
            ViewData["RoleCode"] = new SelectList(_context.Roles, "RoleCode", "RoleName", user.RoleCode);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserCode,UserName,PassWord,RoleCode,LName,FName,NickName,Sex,BirthDate,ExpireTime,Picture,EnterNum,Email,MaritalStatusID,NumberID,Issued,FatherName,EducationalCertificateID,UniversityName,YearGet,Address,Telephone,TelephoneNecessary,BloodTypeID,DrugSensitivity,BeginTime,SectionCodeLab,EmploymentStatusID,HistoryVaccination,HistoryOfOccupationalInjury,RecordTime")] User user)
        {
            if (id != user.UserCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserCode))
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
            ViewData["BloodTypeID"] = new SelectList(_context.BloodTypes, "BloodTypeID", "BloodTypeName", user.BloodTypeID);
            ViewData["EducationalCertificateID"] = new SelectList(_context.EducationalCertificates, "EducationalCertificateId", "EducationalCertificateName", user.EducationalCertificateID);
            ViewData["EmploymentStatusID"] = new SelectList(_context.EmploymentStatuses, "EmploymentStatusID", "EmploymentStatusName", user.EmploymentStatusID);
            ViewData["SectionCodeLab"] = new SelectList(_context.LaboratorySections, "SectionCodeLab", "SectionCodeLab", user.SectionCodeLab);
            ViewData["MaritalStatusID"] = new SelectList(_context.MaritalStatuses, "MaritalStatusID", "MaritalStatusName", user.MaritalStatusID);
            ViewData["RoleCode"] = new SelectList(_context.Roles, "RoleCode", "RoleName", user.RoleCode);
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.BloodType)
                .Include(u => u.EducationalCertificate)
                .Include(u => u.EmploymentStatus)
                .Include(u => u.LaboratorySections)
                .Include(u => u.MaritalStatus)
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.UserCode == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserCode == id);
        }
    }
}
