using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Personaje
    {
        public required int Id { get; set; }
        public required string Nombre { get; set; }
        public required int Vida { get; set; }
        public required int Dinero { get; set; }
        public required int Maiz { get; set; }

        //Variables Keys
        public required int EnemigoId { get; set; }
        public required int MascotaId { get; set; }
        public required int ArmaId { get; set; }
        public required int HerramientaId { get; set; }
        public required int SemillaId { get; set; }
        public required int FertiId { get; set; }





        [ForeignKey("EnemigoId")]
        public required Enemigo Enemigo { get; set; }
        [ForeignKey("MascotaId")]
        public required Mascota Mascota { get; set; }
        [ForeignKey("ArmaId")]
        public required Arma Arma{ get; set; }
        [ForeignKey("HerramientaId")]
        public required Herramienta Herramienta { get; set; }
        [ForeignKey("SemillaId")]
        public required Semilla Semilla { get; set; }
        [ForeignKey("FertiId")]
        public required Fertilizante Fertilizante { get; set; }
    }
}
