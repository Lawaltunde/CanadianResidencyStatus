using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CanadianResidencyStatus.Data;
using AutoMapper;
using CanadianResidencyStatus.Models.StatusInCanada;

namespace CanadianResidencyStatus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusInCanadasController : ControllerBase
    {
        private readonly CanadianRecidencyStatusDbContext _context;
        private readonly IMapper _mapper;

        public StatusInCanadasController(CanadianRecidencyStatusDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        // GET: api/StatusInCanadas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetStatusInCanadaDto>>> GetstatusInCanada()
        {
            var statusInCanada = await _context.statusInCanada.ToListAsync();
            var records = _mapper.Map<List<GetStatusInCanadaDto>>(statusInCanada);
            return Ok(records);
        }

        // GET: api/StatusInCanadas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusInCanadaDto>> GetStatusInCanada(int id)
        {
            var statusInCanada = await _context.statusInCanada.Include(q => q.Residents)
                .FirstOrDefaultAsync(q => q.Id == id);
            

            if (statusInCanada == null)
            {
                return NotFound();
            }

            var records = _mapper.Map<StatusInCanadaDto>(statusInCanada);
            return Ok(records);
        }

        // PUT: api/StatusInCanadas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusInCanada(int id, UpdateStatusInCanadaDto updatestatusInCanadadto)
        {
            if (id != updatestatusInCanadadto.Id)
            {
                return BadRequest();
            }

            //_context.Entry(statusInCanada).State = EntityState.Modified;
            var statusInCanada = await _context.statusInCanada.FindAsync(id);
            if (statusInCanada == null)
            {
                return NotFound();
            }
            _mapper.Map(updatestatusInCanadadto, statusInCanada);

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
        public async Task<ActionResult<StatusInCanada>> PostStatusInCanada(CreateStatusInCanadaDto createStatusInCanadaDto)
        {
            var statusInCanada = _mapper.Map<StatusInCanada>(createStatusInCanadaDto);
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
