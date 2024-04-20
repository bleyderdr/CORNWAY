using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Mascota
    {
        [Key] public int MascotaId { get; set; }
        public required int Vida { get; set; }
        public required int Daño { get; set; }
        [ForeignKey(nameof(Personaje))]
        public int PersonajeId { get; set; }


        public virtual Personaje? Personaje { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;
    }
}
