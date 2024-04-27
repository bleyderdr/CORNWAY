using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUserContoller(ITipoUserService tipoUserService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetTipoUsers()
        {
            IEnumerable<TipoUser> tipoUsers = await tipoUserService.GetTipoUsers();
            return Ok(tipoUsers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoUser(int id)
        {
            TipoUser? tipoUser = await tipoUserService.GetTipoUser(id);
            if (tipoUser == null)
            {
                return NotFound();
            }
            return Ok(tipoUser);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTipoUser(
            [Required][MaxLength(50)] string Nombre
            )
        {
            var tipoUser = await tipoUserService.CreateTipoUser(Nombre);
            return CreatedAtAction(nameof(GetTipoUser), new { id = tipoUser.TipoUserId }, tipoUser);
        }

        [HttpPut]
        public async Task<IActionResult> PutTipoUser(
            [Required] int TipoUserId,
            [MaxLength(50)] string? Nombre
                       )
        {
            var tipoUser = await tipoUserService.PutTipoUser(TipoUserId, Nombre);
            return Ok(tipoUser);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTipoUser(int id)
        {
            var tipoUser = await tipoUserService.DeleteTipoUser(id);
            return Ok(tipoUser);
        }
    }

}
