using Helados.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//Marcus Montilla 2024-1783


namespace Helados.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeladosController : ControllerBase
    {
        private readonly HeladosContext _context;

        public HeladosController(HeladosContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crear")]
        public async Task<IActionResult> CrearHelado(Helado helado)
        {
            await _context.Helados.AddAsync(helado);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<ActionResult<IEnumerable<Helado>>> ListaHelados()
        {
            var helados = await _context.Helados.ToListAsync();

            return Ok(helados);
        }

        [HttpGet]
        [Route("Ver")]
        public async Task<IActionResult> VerHelado(int id)
        {
            Helado helado = await _context.Helados.FindAsync(id);

            if (helado == null)
            {
                return NotFound();

            }
            return Ok(helado);
        }

        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult> ActualizarHelado(int id, Helado helado)
        {
            var heladoExistente = await _context.Helados.FindAsync(id);

            heladoExistente!.Nombre = helado.Nombre;
            heladoExistente.precio = helado.precio;
            heladoExistente.sabor = helado.sabor;

            return Ok();
        }
        [HttpDelete]
        [Route("eliminar")]
        public async Task<IActionResult>EliminarHelado(int id) 
        {
            var heladoBorrado = await _context.Helados.FindAsync(id);
            _context.Helados.Remove(heladoBorrado!);

            await _context.SaveChangesAsync();

            return Ok();

        }
    
        
         

    }
}
