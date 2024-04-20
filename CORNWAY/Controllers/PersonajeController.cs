using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeController(IPersonajeService personajeService) :  ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPersonajes()
        {
            IEnumerable<Personaje> personajes = await personajeService.GetPersonajes();
            return Ok(personajes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonaje(int id)
        {
            Personaje? personaje = await personajeService.GetPersonaje(id);
            if (personaje == null)
            {
                return NotFound();
            }
            return Ok(personaje);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersonaje(
           [Required][MaxLength(40)] string Nombre,
           [Required] int Vida,
           [Required] int Dinero,
           [Required] int Maiz,
           [Required] int MascotaId,
           [Required] int EnemigoId
                       )
        {
            var newPersonaje = await personajeService.CreatePersonaje(Nombre, Vida, Dinero, Maiz, MascotaId, EnemigoId);
            return CreatedAtAction(nameof(GetPersonaje), new { id = newPersonaje.PersonajeId }, newPersonaje);
        }

        [HttpPut]
        public async Task<IActionResult> PutPersonaje(
            [Required] int PersonajeId,
            [MaxLength(40)] string? Nombre,
            [Required] int? Vida,
            [Required] int? Dinero,
            [Required] int? Maiz,
            [Required] int? MascotaId,
            [Required] int? EnemigoId
                       )
        {
            var newPersonaje = await personajeService.PutPersonaje(PersonajeId, Nombre, Vida, Dinero, Maiz, MascotaId, EnemigoId);
            return Ok(newPersonaje);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePersonaje(int id)
        {
            var personaje = await personajeService.DeletePersonaje(id);
            if (personaje == null)
            {
                return NotFound();
            }
            return Ok(personaje);
        }
    }
}
