using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Vet.API.Data;
using Vet.Shared.Entities;


namespace Vet.API.Controllers
{
    [ApiController]
    [Route("/api/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Productos.ToListAsync());
        }
        //para buscar por id

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(x => x.Id == id);
            if (producto is null)
            {
                return NotFound();
            }
            return Ok(producto);

        }





        //para agregar datos
        [HttpPost]
            public async Task<ActionResult> Post(Producto producto)
            {
            _context.Add(producto);
            await _context.SaveChangesAsync();
            return Ok(producto);
        }
        //para modificar datos
        [HttpPut]
        public async Task<ActionResult> Put(Producto producto)
        {
            _context.Update(producto);
            await _context.SaveChangesAsync();
            return Ok(producto);
        }
        ////para eliminar datos por id
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(x => x.Id == id);
            if ( producto is null)
            {
                return NotFound();
            }
            _context.Remove(producto);
            await _context.SaveChangesAsync();
            return NoContent();

        }

    }
}
