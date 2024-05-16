using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CanadianResidencyStatus.Data;

namespace CanadianResidencyStatus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusInCanadasController : ControllerBase
    {
        private readonly CanadianRecidencyStatusDbContext _context;

        public StatusInCanadasController(CanadianRecidencyStatusDbContext context)
        {
            _context = context;
        }

        // GET: api/StatusInCanadas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusInCanada>>> GetstatusInCanada()
        {
            return await _context.statusInCanada.ToListAsync();
        }

        // GET: api/StatusInCanadas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusInCanada>> GetStatusInCanada(int id)
        {
            var statusInCanada = await _context.statusInCanada.FindAsync(id);

            if (statusInCanada == null)
            {
                return NotFound();
            }

            return statusInCanada;
        }

        // PUT: api/StatusInCanadas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusInCanada(int id, StatusInCanada statusInCanada)
        {
            if (id != statusInCanada.Id)
            {
                return BadRequest();
            }

            _context.Entry(statusInCanada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusInCanadaExists(id))
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

        // POST: api/StatusInCanadas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StatusInCanada>> PostStatusInCanada(StatusInCanada statusInCanada)
        {
            _context.statusInCanada.Add(statusInCanada);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatusInCanada", new { id = statusInCanada.Id }, statusInCanada);
        }

        // DELETE: api/StatusInCanadas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatusInCanada(int id)
        {
            var statusInCanada = await _context.statusInCanada.FindAsync(id);
            if (statusInCanada == null)
            {
                return NotFound();
            }

            _context.statusInCanada.Remove(statusInCanada);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatusInCanadaExists(int id)
        {
            return _context.statusInCanada.Any(e => e.Id == id);
        }
    }
}
