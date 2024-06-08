using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CanadianResidencyStatus.Data;
using CanadianResidencyStatus.Models.Job;
using AutoMapper;

namespace CanadianResidencyStatus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly CanadianRecidencyStatusDbContext _context;
        private readonly IMapper _mapper;

        public JobsController(CanadianRecidencyStatusDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        // GET: api/Jobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetJobDto>>> Getjobs()
        {
            var job =  await _context.jobs.ToListAsync();
            var records = _mapper.Map<List<GetJobDto>>(job);
            return Ok(records);
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetJobDto>> GetJob(int id)
        {
            var job = await _context.jobs.Include(q=> q.Residents)
                .FirstOrDefaultAsync(q=> q.Id == id); 

            if (job == null)
            {
                return NotFound();
            }

            var jobDto = _mapper.Map<GetJobDto>(job);

            return Ok(jobDto);
        }

        // PUT: api/Jobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJob(int id, UpdateJobDto updateJobDto)
        {
            if (id != updateJobDto.Id)
            {
                return BadRequest();
            }

            var job = await _context.jobs.FindAsync(id);

            if (job == null)
            {
                return NotFound();
            }

            _mapper.Map(updateJobDto, job);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExists(id))
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

        // POST: api/Jobs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Job>> PostJob(CreateJobDto createJobDto)
        {
            //var Oldjob = new Job
            //{
            //    JobName = createJobDto.JobName,
            //    Position = createJobDto.Position,
            //    Status = createJobDto.Status,
            //    Wages = createJobDto.Wages,
            //    DateOfEmployment = createJobDto.DateOfEmployment
            //};

            var job = _mapper.Map<Job>(createJobDto);

            _context.jobs.Add(job);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJob", new { id = job.Id }, job);
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var job = await _context.jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            _context.jobs.Remove(job);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobExists(int id)
        {
            return _context.jobs.Any(e => e.Id == id);
        }
    }
}
