namespace CORNWAY.Model
{
    public class Personaje
    {
        public required int Id { get; set; }
        public required string Nombre { get; set; }
        public required int Vida { get; set; }
        public required int Dinero { get; set; }
        public required int Maiz { get; set; }

        public virtual ICollection<Arma> Arma { get; set; }
        public virtual ICollection<Semilla> Semilla { get; set; }
    }
}
