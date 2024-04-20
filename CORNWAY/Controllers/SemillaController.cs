using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemillaController(ISemillaService semillaService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetSemillas()
        {
            IEnumerable<Semilla> semillas = await semillaService.GetSemillas();
            return Ok(semillas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSemilla(int id)
        {
            Semilla? semilla = await semillaService.GetSemilla(id);
            if (semilla == null)
            {
                return NotFound();
            }
            return Ok(semilla);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSemilla(
                       [Required] int TiempoCrecimiento,
                                  [Required] int Precio,
                                             [Required] int PersonajeId
                                   )
        {
            var newSemilla = await semillaService.CreateSemilla(TiempoCrecimiento, Precio, PersonajeId);
            return CreatedAtAction(nameof(GetSemilla), new { id = newSemilla.SemillaId }, newSemilla);
        }

        [HttpPut]
        public async Task<IActionResult> PutSemilla(
                       [Required] int SemillaId,
                                  [Required] int? TiempoCrecimiento,
                                             [Required] int? Precio,
                                                        [Required] int? PersonajeId
                                   )
        {
            var newSemilla = await semillaService.PutSemilla(SemillaId, TiempoCrecimiento, Precio, PersonajeId);
            return Ok(newSemilla);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSemilla(int id)
        {
            var semilla = await semillaService.DeleteSemilla(id);
            if (semilla == null)
            {
                return NotFound();
            }
            return Ok(semilla);
        }
    }
}
