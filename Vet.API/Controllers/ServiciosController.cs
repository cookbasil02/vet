using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Vet.API.Data;
using Vet.Shared.Entities;

namespace Vet.API.Controllers
{
    [ApiController]
    [Route("/api/servicios")]
    public class ServiciosController : ControllerBase
    {
        private readonly DataContext _context;

        public ServiciosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Servicios.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var servicio = await _context.Servicios.FirstOrDefaultAsync(x => x.Id == id);
            if (servicio is null)
            {
                return NotFound();
            }
            return Ok(servicio);

        }


        [HttpPost]
        public async Task<ActionResult> Post(Servicio servicio)
        {
            _context.Add(servicio);
            await _context.SaveChangesAsync();
            return Ok(servicio);
        }
        //para modificar datos
        [HttpPut]
        public async Task<ActionResult> Put(Servicio servicio)
        {
            _context.Update(servicio);
            await _context.SaveChangesAsync();
            return Ok(servicio);
        }
        ////para eliminar datos por id
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var servicio = await _context.Servicios.FirstOrDefaultAsync(x => x.Id == id);
            if (servicio is null)
            {
                return NotFound();
            }
            _context.Remove(servicio);
            await _context.SaveChangesAsync();
            return NoContent();

        }

    }
}
