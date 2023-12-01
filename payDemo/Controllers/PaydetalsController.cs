using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using payDemo.Data;
using payDemo.Models;

namespace payDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaydetalsController : ControllerBase
    {
        private readonly payDataContext _context;

        public PaydetalsController(payDataContext context)
        {
            _context = context;
        }

        // GET: api/Paydetals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paydetals>>> Getpaydetals()
        {
            return await _context.paydetals.ToListAsync();
        }

        // GET: api/Paydetals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paydetals>> GetPaydetals(int id)
        {
            var paydetals = await _context.paydetals.FindAsync(id);

            if (paydetals == null)
            {
                return NotFound();
            }

            return paydetals;
        }

        // PUT: api/Paydetals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaydetals(int id, Paydetals paydetals)
        {
            if (id != paydetals.PayId)
            {
                return BadRequest();
            }

            _context.Entry(paydetals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaydetalsExists(id))
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

        // POST: api/Paydetals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Paydetals>> PostPaydetals(Paydetals paydetals)
        {
            _context.paydetals.Add(paydetals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaydetals", new { id = paydetals.PayId }, paydetals);
        }

        // DELETE: api/Paydetals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaydetals(int id)
        {
            var paydetals = await _context.paydetals.FindAsync(id);
            if (paydetals == null)
            {
                return NotFound();
            }

            _context.paydetals.Remove(paydetals);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaydetalsExists(int id)
        {
            return _context.paydetals.Any(e => e.PayId == id);
        }
    }
}
