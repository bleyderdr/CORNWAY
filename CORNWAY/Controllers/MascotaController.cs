using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController(IMascotaService mascotaService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetMascotas()
        {
            IEnumerable<Mascota> mascotas = await mascotaService.GetMascotas();
            return Ok(mascotas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMascota(int id)
        {
            Mascota? mascota = await mascotaService.GetMascota(id);
            if (mascota == null)
            {
                return NotFound();
            }
            return Ok(mascota);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMascota(
            [Required] int Vida,
            [Required] int Daño,
            [Required] int PersonajeId
            )
        {
            var newMascota = await mascotaService.CreateMascota(Vida, Daño, PersonajeId);
            return CreatedAtAction(nameof(GetMascota), new { id = newMascota.MascotaId }, newMascota);
        }

        [HttpPut]
        public async Task<IActionResult> PutMascota(
            [Required] int MascotaId,
            [Required] int? Vida,
            [Required] int? Daño,
            [Required] int? PersonajeId
            )
        {
            var newMascota = await mascotaService.PutMascota(MascotaId, Vida, Daño, PersonajeId);
            return Ok(newMascota);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMascota(int id)
        {
            var mascota = await mascotaService.DeleteMascota(id);
            if (mascota == null)
            {
                return NotFound();
            }
            return Ok(mascota);
        }
    }

}
