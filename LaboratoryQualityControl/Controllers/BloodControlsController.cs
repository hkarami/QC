using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaboratoryQualityControl.Models;
using LaboratoryQualityControl.Services.BloodControls;

namespace LaboratoryQualityControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodControlsController : ControllerBase
    {
        #region [Fields]
        private IBloodControlService _bloodControlService;
        private LaboratoryQCContext _context;
        #endregion

        #region [Ctor]
        public BloodControlsController(IBloodControlService bloodControlService, LaboratoryQCContext dbContext)
        {
            _bloodControlService = bloodControlService;
            _context = dbContext;
        }
        #endregion

        #region [Methods]
        [HttpGet]
        public IEnumerable<BloodControl> GetBloodControlx()
        {
            throw new Exception(""); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBloodControl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bloodControl = await _context.BloodControl.FindAsync(id);

            if (bloodControl == null)
            {
                return NotFound();
            }

            return Ok(bloodControl);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodControl([FromRoute] int id, [FromBody] BloodControl bloodControl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bloodControl.BloodControlId)
            {
                return BadRequest();
            }

            _context.Entry(bloodControl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodControlExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostBloodControl([FromBody] BloodControl bloodControl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BloodControl.Add(bloodControl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBloodControl", new { id = bloodControl.BloodControlId }, bloodControl);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloodControl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bloodControl = await _context.BloodControl.FindAsync(id);
            if (bloodControl == null)
            {
                return NotFound();
            }

            _context.BloodControl.Remove(bloodControl);
            await _context.SaveChangesAsync();

            return Ok(bloodControl);
        }

        private bool BloodControlExists(int id)
        {
            return _context.BloodControl.Any(e => e.BloodControlId == id);
        }
        #endregion
    }
}