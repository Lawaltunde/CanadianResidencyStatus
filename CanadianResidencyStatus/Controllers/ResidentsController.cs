using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CanadianResidencyStatus.Data;
using AutoMapper;
using CanadianResidencyStatus.Models.Resident;
using CanadianResidencyStatus.Models.Country;
using System.Diagnostics.Metrics;

namespace CanadianResidencyStatus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentsController : ControllerBase
    {
        private readonly CanadianRecidencyStatusDbContext _context;
        private readonly IMapper _mapper;

        public ResidentsController(CanadianRecidencyStatusDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Residents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetResidentDto>>> Getresidents()
        {
            var residents = await _context.residents.ToListAsync();
            var records = _mapper.Map<List<GetResidentDto>>(residents);
            return Ok(records);
        }

        // GET: api/Residents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResidentDto>> GetResident(int id)
        {
            var resident = await _context.residents.Include(q => q.country)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (resident == null)
            {
                return NotFound();
            }


            var residentDto = _mapper.Map<ResidentDto>(resident);

            return Ok(residentDto);
        }

        // PUT: api/Residents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResident(int id, UpdateResidentDto updateResidentDto)
        {
            if (id != updateResidentDto.Id)
            {
                return BadRequest();
            }

            //_context.Entry(resident).State = EntityState.Modified;

            var resident = await _context.residents.FindAsync(id);
            if (resident == null)
            {
                return NotFound();
            }
            _mapper.Map(updateResidentDto, resident);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResidentExists(id))
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

        // POST: api/Residents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Resident>> PostResident(CreateResidentDto createResidentDto)
        {
            var resident = _mapper.Map<Resident>(createResidentDto);

            _context.residents.Add(resident);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResident", new { id = resident.Id }, resident);
        }

        // DELETE: api/Residents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResident(int id)
        {
            var resident = await _context.residents.FindAsync(id);
            if (resident == null)
            {
                return NotFound();
            }

            _context.residents.Remove(resident);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResidentExists(int id)
        {
            return _context.residents.Any(e => e.Id == id);
        }
    }
}
