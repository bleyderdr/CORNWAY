using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CORNWAY.Model
{
    public class Sensor
    {
        [Key] public int SensorId { get; set; }
        [MaxLength(50)]
        public required string Nombre { get; set; }
        [MaxLength(50)]
        public required string Descripcion { get; set; }

        [ForeignKey(nameof(Terreno))]
        public int TerrenoId { get; set; }

        public virtual Terreno? Terreno { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;

    }
}
