using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;


namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FertilizanteController(IFertilizanteService fertilizanteService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetFertilizantes()
        {
            IEnumerable<Fertilizante> fertilizantes = await fertilizanteService.GetFertilizantes();
            return Ok(fertilizantes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFertilizante(int id)
        {
            Fertilizante? fertilizante = await fertilizanteService.GetFertilizante(id);
            if (fertilizante == null)
            {
                return NotFound();
            }
            return Ok(fertilizante);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFertilizante(
                                  [Required] string Nombre
                                  )
        {
            var newFertilizante = await fertilizanteService.CreateFertilizante(Nombre);
            return CreatedAtAction(nameof(GetFertilizante), new { id = newFertilizante.FertiId }, newFertilizante);
        }

        [HttpPut]
        public async Task<IActionResult> PutFertilizante(
                                  [Required] int FertiId,
                                                                   [Required] string? Nombre
                                  )
        {
            var newFertilizante = await fertilizanteService.PutFertilizante(FertiId, Nombre);
            return Ok(newFertilizante);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFertilizante(int id)
        {
            var fertilizante = await fertilizanteService.DeleteFertilizante(id);
            if (fertilizante == null)
            {
                return NotFound();
            }
            return Ok(fertilizante);
        }
    }
    
}
