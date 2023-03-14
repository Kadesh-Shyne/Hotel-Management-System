using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_Management_System.Models;
using Hotel_Mgt_System.Data;

namespace Hotel_Mgt_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HostelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Hostels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hostel>>> GetHostel()
        {
            return await _context.Hostel.ToListAsync();
        }

        // GET: api/Hostels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hostel>> GetHostel(int id)
        {
            var hostel = await _context.Hostel.FindAsync(id);

            if (hostel == null)
            {
                return NotFound();
            }

            return hostel;
        }

        // PUT: api/Hostels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHostel(int id, Hostel hostel)
        {
            if (id != hostel.HostelId)
            {
                return BadRequest();
            }

            _context.Entry(hostel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HostelExists(id))
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

        // POST: api/Hostels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hostel>> PostHostel(Hostel hostel)
        {
            _context.Hostel.Add(hostel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHostel", new { id = hostel.HostelId }, hostel);
        }

        // DELETE: api/Hostels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHostel(int id)
        {
            var hostel = await _context.Hostel.FindAsync(id);
            if (hostel == null)
            {
                return NotFound();
            }

            _context.Hostel.Remove(hostel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HostelExists(int id)
        {
            return _context.Hostel.Any(e => e.HostelId == id);
        }
    }
}
