using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class User
    {
        [Key] public int UserId { get; set; }
        [MaxLength(50)]
        public required string Username { get; set; }
        [MaxLength(50)]
        public required string Password { get; set; }
        [MaxLength(50)]
        public required string Email { get; set; }
        [ForeignKey(nameof(TipoUser))]

        public int TipoUserId { get; set; }
        [ForeignKey(nameof(Logro))]
        public int LogroId { get; set; }

        public virtual TipoUser? TipoUser { get; set; }
        public virtual Logro? Logro { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;
    }
}
