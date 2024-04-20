using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController(ISensorService sensorService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetSensores()
        {
            IEnumerable<Sensor> sensores = await sensorService.GetSensores();
            return Ok(sensores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSensor(int id)
        {
            Sensor? sensor = await sensorService.GetSensor(id);
            if (sensor == null)
            {
                return NotFound();
            }
            return Ok(sensor);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSensor(
            [Required][MaxLength(40)] string Nombre,
            [Required][MaxLength(40)] string Descripcion,
            [Required] int TerrenoId
            )
        {
            var newSensor = await sensorService.CreateSensor(Nombre, Descripcion, TerrenoId);
            return CreatedAtAction(nameof(GetSensor), new { id = newSensor.SensorId }, newSensor);
        }

        [HttpPut]
        public async Task<IActionResult> PutSensor(
            [Required] int SensorId,
            [MaxLength(40)] string? Nombre,
            [MaxLength(40)] string? Descripcion,
            [Required] int? TerrenoId
            )
        {
            var newSensor = await sensorService.PutSensor(SensorId, Nombre, Descripcion, TerrenoId);
            return Ok(newSensor);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSensor(int id)
        {
            var sensor = await sensorService.DeleteSensor(id);
            if (sensor == null)
            {
                return NotFound();
            }
            return Ok(sensor);
        }
    }

}
