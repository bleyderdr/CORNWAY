using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Terreno
    {
        [Key] public int TerrenoId { get; set; }
        public required string Humedad { get; set; }
        public required string Temperatura { get; set; }

        public int SensorId { get; set; }
        public int FertiId { get; set; }
        public int SemillaId { get; set; }


        [ForeignKey("SensorId")]
        public required Sensor Sensor{ get; set; }
        [ForeignKey("FertiId")]
        public required Fertilizante Fertilizante { get; set; }
        [ForeignKey("SemillaId")]
        public required Semilla Semilla { get; set; }

    }
}
