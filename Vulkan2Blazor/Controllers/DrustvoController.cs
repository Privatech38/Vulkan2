using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vulkan2Blazor.Data;
using Vulkan2Blazor.Models;

namespace Vulkan2Blazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrustvoController : ControllerBase
    {
        private readonly Vulkan2Context _context;

        public DrustvoController(Vulkan2Context context)
        {
            _context = context;
        }

        // GET: api/Drustvo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GasilskoDrustvo>>> GetGasilskoDrustvo()
        {
            return await _context.GasilskoDrustvo.ToListAsync();
        }

        // GET: api/Drustvo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GasilskoDrustvo>> GetGasilskoDrustvo(int id)
        {
            var gasilskoDrustvo = await _context.GasilskoDrustvo.FindAsync(id);

            if (gasilskoDrustvo == null)
            {
                return NotFound();
            }

            return gasilskoDrustvo;
        }

        // PUT: api/Drustvo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGasilskoDrustvo(int id, GasilskoDrustvo gasilskoDrustvo)
        {
            if (id != gasilskoDrustvo.GasilskoDrustvoId)
            {
                return BadRequest();
            }

            _context.Entry(gasilskoDrustvo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GasilskoDrustvoExists(id))
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

        // POST: api/Drustvo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GasilskoDrustvo>> PostGasilskoDrustvo(GasilskoDrustvo gasilskoDrustvo)
        {
            _context.GasilskoDrustvo.Add(gasilskoDrustvo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGasilskoDrustvo", new { id = gasilskoDrustvo.GasilskoDrustvoId }, gasilskoDrustvo);
        }

        // DELETE: api/Drustvo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGasilskoDrustvo(int id)
        {
            var gasilskoDrustvo = await _context.GasilskoDrustvo.FindAsync(id);
            if (gasilskoDrustvo == null)
            {
                return NotFound();
            }

            _context.GasilskoDrustvo.Remove(gasilskoDrustvo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GasilskoDrustvoExists(int id)
        {
            return _context.GasilskoDrustvo.Any(e => e.GasilskoDrustvoId == id);
        }
    }
}
