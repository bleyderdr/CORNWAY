namespace CORNWAY.Model
{
    public class Arma
    {
        public required int ArmaId { get; set; }
        public required int Daño { get; set; }
        public required string Tipo { get; set; }
        public required int Precio { get; set; }

        public Arma()
        {
        }
    }
    
}
