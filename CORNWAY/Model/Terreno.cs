using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Terreno
    {
        [Key] public int TerrenoId { get; set; }
        public required int Humedad { get; set; }
        public required int Temperatura { get; set; }

        public int SensorId { get; set; }
        public int FertiId { get; set; }
        public int SemillaId { get; set; }


        [ForeignKey("SensorId")]
        public Sensor Sensor{ get; set; }
        [ForeignKey("FertiId")]
        public Fertilizante Fertilizante { get; set; }
        [ForeignKey("SemillaId")]
        public Semilla Semilla { get; set; }

    }
}
