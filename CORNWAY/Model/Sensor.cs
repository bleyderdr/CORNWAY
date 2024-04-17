using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Sensor
    {
        [Key] public int SensorId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Terreno Terreno { get; set; }

    }
}
