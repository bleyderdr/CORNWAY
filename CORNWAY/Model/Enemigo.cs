using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Enemigo
    {
        [Key] public required int EnemigoId { get; set; }
        public required int Vida { get; set; }
        public required int Daño { get; set; }
        public required int Recompensa { get; set; }

        public List<Personaje> Personaje { get; set; } = new List<Personaje>();
    }
}
