using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerrenoController(ITerrenoService terrenoService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetTerrenos()
        {
            IEnumerable<Terreno> terrenos = await terrenoService.GetTerrenos();
            return Ok(terrenos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTerreno(int id)
        {
            Terreno? terreno = await terrenoService.GetTerreno(id);
            if (terreno == null)
            {
                return NotFound();
            }
            return Ok(terreno);
        }

        [HttpPost]
        public async Task<IActionResult> Createterreno(
            [Required] int Humedad,
            [Required] int Temperatura,
            [Required] int SensorId,
            [Required] int FertiId,
            [Required] int SemillaId
            )
        {
            var newTerreno = await terrenoService.CreateTerreno(Humedad, Temperatura, SensorId, FertiId, SemillaId);
            return CreatedAtAction(nameof(GetTerreno), new { id = newTerreno.TerrenoId }, newTerreno);
        }

        [HttpPut]
        public async Task<IActionResult> PutTerreno(
                       [Required] int TerrenoId,
                                  [Required] int? Humedad,
                                             [Required] int? Temperatura,
                                                        [Required] int? SensorId,
                                                                   [Required] int? FertiId,
                                                                              [Required] int? SemillaId
                       )
        {
            var newTerreno = await terrenoService.PutTerreno(TerrenoId, Humedad, Temperatura, SensorId, FertiId, SemillaId);
            return Ok(newTerreno);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTerreno(int id)
        {
            var terreno = await terrenoService.DeleteTerreno(id);
            if (terreno == null)
            {
                return NotFound();
            }
            return Ok(terreno);
        }
    }
}
