using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Personaje
    {
        [Key] public int PersonajeId { get; set; }
        [MaxLength(50)]
        public required string Nombre { get; set; }
        public required int Vida { get; set; }
        public required int Dinero { get; set; }
        public required int Maiz { get; set; }
        [ForeignKey(nameof(Enemigo))]
        public int EnemigoId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User? Usuario { get; set; }
        public virtual Enemigo? Enemigo { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;

    }
}
