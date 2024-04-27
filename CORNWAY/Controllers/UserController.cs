using System.ComponentModel.DataAnnotations;
using CORNWAY.Model;
using CORNWAY.Services;
using Microsoft.AspNetCore.Mvc;

namespace CORNWAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            IEnumerable<User> users = await userService.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            User? user = await userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(
            [Required][MaxLength(50)] string Username,
            [Required][MaxLength(320)][EmailAddress(ErrorMessage = "Correro incorrecto")] string Email,
            [Required][MaxLength(50)] string Password,
            [Required] int TipoUserId,
            [Required] int PersonajeId,
            [Required] int LogroId
            )
        {
            var user = await userService.CreateUser(Username, Email, Password, TipoUserId, PersonajeId, LogroId);
            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }

        [HttpPut]
        public async Task<IActionResult> PutUser(
            [Required] int UserId,
            [MaxLength(50)] string? Username,
            [MaxLength(320)][EmailAddress(ErrorMessage = "Correo incorrecto")] string? Email,
            [MaxLength(50)] string? Password,
            int? TipoUserId,
            int? PersonajeId,
                                                                                         int? LogroId
            )
        {
            var user = await userService.PutUser(UserId, Username, Email, Password, TipoUserId, PersonajeId, LogroId);
            return Ok(user);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await userService.DeleteUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }

}
