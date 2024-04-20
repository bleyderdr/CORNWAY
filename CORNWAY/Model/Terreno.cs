using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Terreno
    {
        [Key] public int TerrenoId { get; set; }
        public required int Humedad { get; set; }
        public required int Temperatura { get; set; }
        [ForeignKey(nameof(Fertilizante))]
        public int FertiId { get; set; }
        [ForeignKey(nameof(Semilla))]
        public int SemillaId { get; set; }

        public virtual Fertilizante? Fertilizante { get; set; }
        public virtual Semilla? Semilla { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;

    }
}
