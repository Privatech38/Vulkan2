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
    public class ZvezaController : ControllerBase
    {
        private readonly Vulkan2Context _context;

        public ZvezaController(Vulkan2Context context)
        {
            _context = context;
        }

        // GET: api/Zveza
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GasilskaZveza>>> GetGasilskaZveza()
        {
            return await _context.GasilskaZveza.ToListAsync();
        }

        // GET: api/Zveza/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GasilskaZveza>> GetGasilskaZveza(int id)
        {
            var gasilskaZveza = await _context.GasilskaZveza.FindAsync(id);

            if (gasilskaZveza == null)
            {
                return NotFound();
            }

            return gasilskaZveza;
        }

        // PUT: api/Zveza/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGasilskaZveza(int id, GasilskaZveza gasilskaZveza)
        {
            if (id != gasilskaZveza.GasilskaZvezaId)
            {
                return BadRequest();
            }

            _context.Entry(gasilskaZveza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GasilskaZvezaExists(id))
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

        // POST: api/Zveza
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GasilskaZveza>> PostGasilskaZveza(GasilskaZveza gasilskaZveza)
        {
            _context.GasilskaZveza.Add(gasilskaZveza);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGasilskaZveza", new { id = gasilskaZveza.GasilskaZvezaId }, gasilskaZveza);
        }

        // DELETE: api/Zveza/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGasilskaZveza(int id)
        {
            var gasilskaZveza = await _context.GasilskaZveza.FindAsync(id);
            if (gasilskaZveza == null)
            {
                return NotFound();
            }

            _context.GasilskaZveza.Remove(gasilskaZveza);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GasilskaZvezaExists(int id)
        {
            return _context.GasilskaZveza.Any(e => e.GasilskaZvezaId == id);
        }
    }
}
