using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Sensor
    {
        [Key] public required int SensorId { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }

        public required Terreno Terreno { get; set; }

    }
}
