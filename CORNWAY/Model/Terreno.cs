namespace CORNWAY.Model
{
    public class Terreno
    {
        public required int TerrenoId { get; set; }
        public required string Humedad { get; set; }
        public required string Temperatura { get; set; }

        public required string SensorId { get; set; }
        public required string FertiId { get; set; }


        [ForeignKey("SensorId")]
        public required Sensor Sensor{ get; set; }
        [ForeignKey("FertiId")]
        public required Fertilizante Fertilizante { get; set; }

    }
}
