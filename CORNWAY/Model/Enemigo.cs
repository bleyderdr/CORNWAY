using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class Enemigo
    {
        [Key] public int EnemigoId { get; set; }
        public required int Vida { get; set; }
        public required int Daño { get; set; }
        public required int Recompenza { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;

    }
}
