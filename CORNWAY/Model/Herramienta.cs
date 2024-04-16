using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Herramienta
    {
        [Key] public required int HerramientaId { get; set; }
        public required string Tipo { get; set; }

    }
}
