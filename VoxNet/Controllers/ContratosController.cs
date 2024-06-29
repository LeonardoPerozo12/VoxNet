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
    public class ContratosController : ControllerBase
    {
        private readonly VoxNetContext _context;

        public ContratosController(VoxNetContext context)
        {
            _context = context;
        }

        // GET: api/Contratos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contratos>>> GetContratos()
        {
            return await _context.Contratos.ToListAsync();
        }

        // GET: api/Contratos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contratos>> GetContratos(int id)
        {
            var contratos = await _context.Contratos.FindAsync(id);

            if (contratos == null)
            {
                return NotFound();
            }

            return contratos;
        }

        // PUT: api/Contratos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContratos(int id, Contratos contratos)
        {
            if (id != contratos.IdContrato)
            {
                return BadRequest();
            }

            _context.Entry(contratos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContratosExists(id))
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

        // POST: api/Contratos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contratos>> PostContratos(Contratos contratos)
        {
            _context.Contratos.Add(contratos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContratos", new { id = contratos.IdContrato }, contratos);
        }

        // DELETE: api/Contratos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContratos(int id)
        {
            var contratos = await _context.Contratos.FindAsync(id);
            if (contratos == null)
            {
                return NotFound();
            }

            _context.Contratos.Remove(contratos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContratosExists(int id)
        {
            return _context.Contratos.Any(e => e.IdContrato == id);
        }
    }
}
