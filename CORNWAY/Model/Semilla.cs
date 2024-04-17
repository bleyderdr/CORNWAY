using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Semilla
    {
        [Key] public int SemillaId { get; set; }
        public required int TiempoCrecimiento { get; set; }
        public required int Precio { get; set; }
        public required int PersonajeId { get; set; }

        public List<Terreno> Terrenos { get; set; } = new List<Terreno>();

        [ForeignKey("PersonajeId")]
        public Personaje Personaje { get; set; }


        public Semilla()
        {

        }

        public void Plantar(Personaje personaje)
        {
            // Implementar la lógica de plantar la semilla
        }

        public void Cosechar(Personaje personaje)
        {
            // Implementar la lógica de cosechar la semilla
        }
    }
}
