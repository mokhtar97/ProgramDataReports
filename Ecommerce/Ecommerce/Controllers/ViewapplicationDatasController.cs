using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;
using Ecommerce.Models.Repositories;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewapplicationDatasController : ControllerBase
    {
        private readonly ApplicationDbcontext _context;
        private readonly IStore<ViewapplicationData> viewdata;

        public ViewapplicationDatasController(ApplicationDbcontext context,IStore<ViewapplicationData> viewdata)
        {
            _context = context;
            this.viewdata = viewdata;
        }

        // GET: api/ViewapplicationDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewapplicationData>>> GetViewapplicationData()
        {
            return viewdata.List();
        }

        // GET: api/ViewapplicationDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewapplicationData>> GetViewapplicationData(int id)
        {
            var viewapplicationData = await _context.ViewapplicationData.FindAsync(id);

            if (viewapplicationData == null)
            {
                return NotFound();
            }

            return viewapplicationData;
        }

        // PUT: api/ViewapplicationDatas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViewapplicationData(int id, ViewapplicationData viewapplicationData)
        {
            if (id != viewapplicationData.ID)
            {
                return BadRequest();
            }

            _context.Entry(viewapplicationData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViewapplicationDataExists(id))
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

        // POST: api/ViewapplicationDatas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ViewapplicationData>> PostViewapplicationData(ViewapplicationData viewapplicationData)
        {
            _context.ViewapplicationData.Add(viewapplicationData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViewapplicationData", new { id = viewapplicationData.ID }, viewapplicationData);
        }

        // DELETE: api/ViewapplicationDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ViewapplicationData>> DeleteViewapplicationData(int id)
        {
            var viewapplicationData = await _context.ViewapplicationData.FindAsync(id);
            if (viewapplicationData == null)
            {
                return NotFound();
            }

            _context.ViewapplicationData.Remove(viewapplicationData);
            await _context.SaveChangesAsync();

            return viewapplicationData;
        }

        private bool ViewapplicationDataExists(int id)
        {
            return _context.ViewapplicationData.Any(e => e.ID == id);
        }
    }
}
