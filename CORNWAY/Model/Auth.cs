using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
namespace CORNWAY.Model
{
    public class Auth
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
