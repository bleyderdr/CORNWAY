using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Personaje
    {
        [Key] public required int PersonajeId { get; set; }
        public required string Nombre { get; set; }
        public required int Vida { get; set; }
        public required int Dinero { get; set; }
        public required int Maiz { get; set; }

        //Variables Keys
        public int MascotaId { get; set; }
        public int EnemigoId { get; set; }

        public List<Herramienta> Herramienta { get; set; } = new List<Herramienta>();
        public List<Arma> Arma { get; set; } = new List<Arma>();
        public List<Semilla> Semilla { get; set; } = new List<Semilla>();



        [ForeignKey("EnemigoId")]
        public required Enemigo Enemigo { get; set; }

        [ForeignKey("MascotaId")]
        public required Mascota Mascota { get; set; }

       
    }
}
