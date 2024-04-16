using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Mascota
    {
        [Key] public int MascotaId { get; set; }
        public required int Vida { get; set; }
        public required int Daño { get; set; }

        public int PersonajeId { get; set; }


        public required Personaje Personaje { get; set; }
    }
}
