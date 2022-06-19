using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

namespace backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CupsController : ControllerBase
    {
        private readonly CupsContext _context;

        public CupsController(CupsContext context)
        {
            _context = context;
        }

        // GET: api/Cups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cups>>> GetCups()
        {
            return await _context.Cups.ToListAsync();
        }

        // GET: api/Cups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cups>> GetCups(int id)
        {
            var cups = await _context.Cups.FindAsync(id);

            if (cups == null)
            {
                return NotFound();
            }

            return cups;
        }

        // PUT: api/Cups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCups(int id, Cups cups)
        {
            if (id != cups.CupsId)
            {
                return BadRequest();
            }

            _context.Entry(cups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CupsExists(id))
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

        // POST: api/Cups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cups>> PostCups(Cups cups)
        {
            _context.Cups.Add(cups);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCups", new { id = cups.CupsId }, cups);
        }

        // DELETE: api/Cups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCups(int id)
        {
            var cups = await _context.Cups.FindAsync(id);
            if (cups == null)
            {
                return NotFound();
            }

            _context.Cups.Remove(cups);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CupsExists(int id)
        {
            return _context.Cups.Any(e => e.CupsId == id);
        }
    }
}
