using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationProgramsController : ControllerBase
    {
        private readonly ApplicationDbcontext _context;

        public ApplicationProgramsController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: api/ApplicationPrograms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationProgram>>> GetProgram()
        {
            return await _context.Program.ToListAsync();
        }

        // GET: api/ApplicationPrograms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationProgram>> GetApplicationProgram(int id)
        {
            var applicationProgram = await _context.Program.FindAsync(id);

            if (applicationProgram == null)
            {
                return NotFound();
            }

            return applicationProgram;
        }

        // PUT: api/ApplicationPrograms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationProgram(int id, ApplicationProgram applicationProgram)
        {
            if (id != applicationProgram.ID)
            {
                return BadRequest();
            }

            _context.Entry(applicationProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationProgramExists(id))
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

        // POST: api/ApplicationPrograms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ApplicationProgram>> PostApplicationProgram(ApplicationProgram applicationProgram)
        {
            _context.Program.Add(applicationProgram);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicationProgram", new { id = applicationProgram.ID }, applicationProgram);
        }

        // DELETE: api/ApplicationPrograms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApplicationProgram>> DeleteApplicationProgram(int id)
        {
            var applicationProgram = await _context.Program.FindAsync(id);
            if (applicationProgram == null)
            {
                return NotFound();
            }

            _context.Program.Remove(applicationProgram);
            await _context.SaveChangesAsync();

            return applicationProgram;
        }

        private bool ApplicationProgramExists(int id)
        {
            return _context.Program.Any(e => e.ID == id);
        }
    }
}
