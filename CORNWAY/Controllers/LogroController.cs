using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogroController(ILogroService logroService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetLogros()
        {
            IEnumerable<Logro> logros = await logroService.GetLogros();
            return Ok(logros);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLogro(int id)
        {
            Logro? logro = await logroService.GetLogro(id);
            if (logro == null)
            {
                return NotFound();
            }
            return Ok(logro);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLogro(
            [Required][MaxLength(50)] string Nombre
            )
        {
            var logro = await logroService.CreateLogro(Nombre);
            return CreatedAtAction(nameof(GetLogro), new { id = logro.LogroId }, logro);
        }

        [HttpPut]
        public async Task<IActionResult> PutLogro(
            [Required] int LogroId,
            [MaxLength(50)] string? Nombre
            )
        {
            var logro = await logroService.PutLogro(LogroId, Nombre);
            return Ok(logro);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLogro(int id)
        {
            var logro = await logroService.DeleteLogro(id);
            return Ok(logro);
        }
    }
    
}
