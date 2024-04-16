using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Arma
    {
        [Key] public required int ArmaId { get; set; }
        public required int Daño { get; set; }
        public required string Tipo { get; set; }
        public required int Precio { get; set; }

        public Arma()
        {
        }
    }
    
}
