using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Vet.API.Data;
using Vet.Shared.Entities;

namespace Vet.API.Controllers
{
    [ApiController]
    [Route("/api/mascotas")]
    public class MascotasController: ControllerBase
    {
        private readonly DataContext _context;

        public MascotasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Mascotas.ToListAsync());
        }
        //para buscar por id

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var mascota = await _context.Mascotas.FirstOrDefaultAsync(x => x.Id == id);
            if (mascota is null)
            {
                return NotFound();
            }
            return Ok(mascota);

        }
        //para  agregar datos
        [HttpPost]
        public async Task<ActionResult> Post(Mascota mascota)
        {
            _context.Add(mascota);
            await _context.SaveChangesAsync();
            return Ok(mascota);
        }
        //para modificar datos
        [HttpPut]
        public async Task<ActionResult> Put(Mascota mascota)
        {
            _context.Update(mascota);
            await _context.SaveChangesAsync();
            return Ok(mascota);
        }
        //para eliminar datos por id
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var mascota = await _context.Mascotas.FirstOrDefaultAsync(x => x.Id == id);
            if (mascota is null)
            {
                return NotFound();
            }
            _context.Remove(mascota);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}
