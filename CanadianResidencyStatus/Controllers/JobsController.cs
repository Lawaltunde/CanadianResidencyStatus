﻿using System;
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
    public class JobsController : ControllerBase
    {
        private readonly CanadianRecidencyStatusDbContext _context;

        public JobsController(CanadianRecidencyStatusDbContext context)
        {
            _context = context;
        }

        // GET: api/Jobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job>>> Getjobs()
        {
            return await _context.jobs.ToListAsync();
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetJob(int id)
        {
            var job = await _context.jobs.FindAsync(id);

            if (job == null)
            {
                return NotFound();
            }

            return job;
        }

        // PUT: api/Jobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJob(int id, Job job)
        {
            if (id != job.Id)
            {
                return BadRequest();
            }

            _context.Entry(job).State = EntityState.Modified;

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
        public async Task<ActionResult<Job>> PostJob(Job job)
        {
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
