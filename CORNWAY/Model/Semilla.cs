using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CORNWAY.Model
{
    public class Semilla
    {
        [Key] public int SemillaId { get; set; }
        public required int TiempoCrecimiento { get; set; }
        public required int Precio { get; set; }
        [ForeignKey(nameof(Personaje))]
        public required int PersonajeId { get; set; }

        public virtual Personaje? Personaje { get; set; }
    }
}
