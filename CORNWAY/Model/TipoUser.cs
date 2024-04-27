﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORNWAY.Model
{
    public class TipoUser
    {
        [Key] public int TipoUserId { get; set; }
        [MaxLength(50)]
        public required string Nombre { get; set; }
        [JsonIgnore]
        public bool IsActive { get; set; } = true;
    }
}
