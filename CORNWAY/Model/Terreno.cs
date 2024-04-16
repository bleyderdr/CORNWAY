using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Terreno
    {
        [Key] public required int TerrenoId { get; set; }
        public required string Humedad { get; set; }
        public required string Temperatura { get; set; }

        public required int SensorId { get; set; }
        public required int FertiId { get; set; }


        [ForeignKey("SensorId")]
        public required Sensor Sensor{ get; set; }
        [ForeignKey("FertiId")]
        public required Fertilizante Fertilizante { get; set; }

    }
}
