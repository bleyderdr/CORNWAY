using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Fertilizante
    {
        [Key] public int FertiId { get; set; }
        public required string Nombre { get; set; }
    }
}
