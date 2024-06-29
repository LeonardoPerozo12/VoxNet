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
    public class ProductosFacturasController : ControllerBase
    {
        private readonly VoxNetContext _context;

        public ProductosFacturasController(VoxNetContext context)
        {
            _context = context;
        }

        // GET: api/ProductosFacturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductosFacturas>>> GetProductosFacturas()
        {
            return await _context.ProductosFacturas.ToListAsync();
        }

        // GET: api/ProductosFacturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductosFacturas>> GetProductosFacturas(int id)
        {
            var productosFacturas = await _context.ProductosFacturas.FindAsync(id);

            if (productosFacturas == null)
            {
                return NotFound();
            }

            return productosFacturas;
        }

        // PUT: api/ProductosFacturas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductosFacturas(int id, ProductosFacturas productosFacturas)
        {
            if (id != productosFacturas.IdFactura)
            {
                return BadRequest();
            }

            _context.Entry(productosFacturas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductosFacturasExists(id))
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

        // POST: api/ProductosFacturas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductosFacturas>> PostProductosFacturas(ProductosFacturas productosFacturas)
        {
            _context.ProductosFacturas.Add(productosFacturas);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductosFacturasExists(productosFacturas.IdFactura))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductosFacturas", new { id = productosFacturas.IdFactura }, productosFacturas);
        }

        // DELETE: api/ProductosFacturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductosFacturas(int id)
        {
            var productosFacturas = await _context.ProductosFacturas.FindAsync(id);
            if (productosFacturas == null)
            {
                return NotFound();
            }

            _context.ProductosFacturas.Remove(productosFacturas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductosFacturasExists(int id)
        {
            return _context.ProductosFacturas.Any(e => e.IdFactura == id);
        }
    }
}
