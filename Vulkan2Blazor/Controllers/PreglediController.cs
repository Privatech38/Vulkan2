using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vulkan2Blazor.Data;
using Vulkan2Blazor.Models.ClanAttributes;

namespace Vulkan2Blazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreglediController : ControllerBase
    {
        private readonly Vulkan2Context _context;

        public PreglediController(Vulkan2Context context)
        {
            _context = context;
        }

        // GET: api/Pregledi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZdravstveniPregled>>> GetZdravstveniPregled()
        {
            return await _context.ZdravstveniPregled.ToListAsync();
        }

        // GET: api/Pregledi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZdravstveniPregled>> GetZdravstveniPregled(int id)
        {
            var zdravstveniPregled = await _context.ZdravstveniPregled.FindAsync(id);

            if (zdravstveniPregled == null)
            {
                return NotFound();
            }

            return zdravstveniPregled;
        }

        // PUT: api/Pregledi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZdravstveniPregled(int id, ZdravstveniPregled zdravstveniPregled)
        {
            if (id != zdravstveniPregled.ZdravstveniPregledId)
            {
                return BadRequest();
            }

            _context.Entry(zdravstveniPregled).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZdravstveniPregledExists(id))
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

        // POST: api/Pregledi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ZdravstveniPregled>> PostZdravstveniPregled(ZdravstveniPregled zdravstveniPregled)
        {
            _context.ZdravstveniPregled.Add(zdravstveniPregled);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZdravstveniPregled", new { id = zdravstveniPregled.ZdravstveniPregledId }, zdravstveniPregled);
        }

        // DELETE: api/Pregledi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZdravstveniPregled(int id)
        {
            var zdravstveniPregled = await _context.ZdravstveniPregled.FindAsync(id);
            if (zdravstveniPregled == null)
            {
                return NotFound();
            }

            _context.ZdravstveniPregled.Remove(zdravstveniPregled);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZdravstveniPregledExists(int id)
        {
            return _context.ZdravstveniPregled.Any(e => e.ZdravstveniPregledId == id);
        }
    }
}
