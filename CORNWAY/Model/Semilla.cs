using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CORNWAY.Model
{
    public class Semilla
    {
        public int Id { get; set; }
        public int TiempoCrecimiento { get; set; }
        public int Precio { get; set; }

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
