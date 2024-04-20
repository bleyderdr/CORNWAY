using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Herramienta
    {
        [Key] public int HerramientaId { get; set; }
        [MaxLength(50)]
        public required string Tipo { get; set; }
        [ForeignKey(nameof(Personaje))]
        public required int PersonajeId { get; set; }

        public virtual Personaje? Personaje { get; set; }

    }
}
