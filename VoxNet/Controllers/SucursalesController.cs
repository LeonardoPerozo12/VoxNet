using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoxNet.Context;
using VoxNet.Models;

namespace VoxNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalesController : ControllerBase
    {
        private readonly VoxNetContext _context;

        public SucursalesController(VoxNetContext context)
        {
            _context = context;
        }

        // GET: api/Sucursales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sucursales>>> GetSucursales()
        {
            return await _context.Sucursales.ToListAsync();
        }

        // GET: api/Sucursales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sucursales>> GetSucursales(int id)
        {
            var sucursales = await _context.Sucursales.FindAsync(id);

            if (sucursales == null)
            {
                return NotFound();
            }

            return sucursales;
        }

        // PUT: api/Sucursales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSucursales(int id, Sucursales sucursales)
        {
            if (id != sucursales.IdSucursal)
            {
                return BadRequest();
            }

            _context.Entry(sucursales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SucursalesExists(id))
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

        // POST: api/Sucursales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sucursales>> PostSucursales(Sucursales sucursales)
        {
            _context.Sucursales.Add(sucursales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSucursales", new { id = sucursales.IdSucursal }, sucursales);
        }

        // DELETE: api/Sucursales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSucursales(int id)
        {
            var sucursales = await _context.Sucursales.FindAsync(id);
            if (sucursales == null)
            {
                return NotFound();
            }

            _context.Sucursales.Remove(sucursales);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SucursalesExists(int id)
        {
            return _context.Sucursales.Any(e => e.IdSucursal == id);
        }
    }
}
