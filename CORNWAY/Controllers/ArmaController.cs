using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmaController(IArmaService armaService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetArmas()
        {
            IEnumerable<Arma> armas = await armaService.GetArmas();
            return Ok(armas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArma(int id)
        {
            Arma? arma = await armaService.GetArma(id);
            if (arma == null)
            {
                return NotFound();
            }
            return Ok(arma);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArma(
            [Required] int Daño,
            [Required][MaxLength(30)] string Tipo,
            [Required] int Precio,
            [Required] int PersonajeId
         )
        {
            var newArma = await armaService.CreateArma(Daño, Tipo, Precio, PersonajeId);
            return CreatedAtAction(nameof(GetArma), new { id = newArma.ArmaId }, newArma);
        }

        [HttpPut]
        public async Task<IActionResult> PutArma(
            [Required] int ArmaId,
            [Required] int? Daño,
            [Required][MaxLength(30)] string Tipo,
            [Required] int? Precio,
            [Required] int? PersonajeId
                    
                       )
        {
            var newArma = await armaService.PutArma(ArmaId, Daño, Tipo, Precio, PersonajeId);
            return Ok(newArma);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteArma(int id)
        {
            var arma = await armaService.DeleteArma(id);
            if (arma == null)
            {
                return NotFound();
            }
            return Ok(arma);
        }
    }

}
