using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Arma
    {
        [Key] public int ArmaId { get; set; }
        public required int Daño { get; set; }
        [MaxLength(50)]
        public required string Tipo { get; set; }
        public required int Precio { get; set; }
        [ForeignKey(nameof(Personaje))]
        public required int PersonajeId { get; set; }

        public virtual Personaje? Personaje { get; set; }

    }
    
}
