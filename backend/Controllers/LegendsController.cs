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
    public class LegendsController : ControllerBase
    {
        private readonly LegendsContext _context;

        public LegendsController(LegendsContext context)
        {
            _context = context;
        }

        // GET: api/Legends
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Legends>>> GetLegends()
        {
            return await _context.Legends.ToListAsync();
        }

        // GET: api/Legends/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Legends>> GetLegends(int id)
        {
            var legends = await _context.Legends.FindAsync(id);

            if (legends == null)
            {
                return NotFound();
            }

            return legends;
        }

        // PUT: api/Legends/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegends(int id, Legends legends)
        {
            if (id != legends.LegendsId)
            {
                return BadRequest();
            }

            _context.Entry(legends).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegendsExists(id))
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

        // POST: api/Legends
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Legends>> PostLegends(Legends legends)
        {
            _context.Legends.Add(legends);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLegends", new { id = legends.LegendsId }, legends);
        }

        // DELETE: api/Legends/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLegends(int id)
        {
            var legends = await _context.Legends.FindAsync(id);
            if (legends == null)
            {
                return NotFound();
            }

            _context.Legends.Remove(legends);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LegendsExists(int id)
        {
            return _context.Legends.Any(e => e.LegendsId == id);
        }
    }
}
