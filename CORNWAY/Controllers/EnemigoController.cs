using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;


namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnemigoController(IEnemigoService enemigoService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetEnemigos()
        {
            IEnumerable<Enemigo> enemigos = await enemigoService.GetEnemigos();
            return Ok(enemigos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEnemigo(int id)
        {
            Enemigo? enemigo = await enemigoService.GetEnemigo(id);
            if (enemigo == null)
            {
                return NotFound();
            }
            return Ok(enemigo);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEnemigo(
                       [Required] int Vida,
                                  [Required] int Daño,
                                             [Required] int Recompenza
                       )
        {
            var newEnemigo = await enemigoService.CreateEnemigo(Vida, Daño, Recompenza);
            return CreatedAtAction(nameof(GetEnemigo), new { id = newEnemigo.EnemigoId }, newEnemigo);
        }

        [HttpPut]
        public async Task<IActionResult> PutEnemigo(
                       [Required] int EnemigoId,
                                  [Required] int? Vida,
                                             [Required] int? Daño,
                                                        [Required] int? Recompenza
                       )
        {
            var newEnemigo = await enemigoService.PutEnemigo(EnemigoId, Vida, Daño, Recompenza);
            return Ok(newEnemigo);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEnemigo(int id)
        {
            var enemigo = await enemigoService.DeleteEnemigo(id);
            if (enemigo == null)
            {
                return NotFound();
            }
            return Ok(enemigo);
        }
    }

}

