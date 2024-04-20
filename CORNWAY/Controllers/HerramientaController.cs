using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerramientaController(IHerramientaService herramientaService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetHerramientas()
        {
            IEnumerable<Herramienta> herramientas = await herramientaService.GetHerramientas();
            return Ok(herramientas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHerramienta(int id)
        {
            Herramienta? herramienta = await herramientaService.GetHerramienta(id);
            if (herramienta == null)
            {
                return NotFound();
            }
            return Ok(herramienta);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHerramienta(
            [Required][MaxLength(40)] string Tipo,
            [Required] int PersonajeId
            )
        {
            var newHerramienta = await herramientaService.CreateHerramienta(Tipo, PersonajeId);
            return CreatedAtAction(nameof(GetHerramienta), new { id = newHerramienta.HerramientaId }, newHerramienta);
        }

        [HttpPut]
        public async Task<IActionResult> PutHerramienta(
            [Required] int HerramientaId,
            [MaxLength(40)] string? Tipo,
            [Required] int? PersonajeId
                       )
        {
            var newHerramienta = await herramientaService.PutHerramienta(HerramientaId, Tipo, PersonajeId);
            return Ok(newHerramienta);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteHerramienta(int id)
        {
            var herramienta = await herramientaService.DeleteHerramienta(id);
            if (herramienta == null)
            {
                return NotFound();
            }
            return Ok(herramienta);
        }
    }
}
