namespace CORNWAY.Model
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Experiencia { get; set; }
        public int Nivel { get; set; }
        public int Dinero { get; set; }
        public int Maiz { get; set; }

        public virtual ICollection<Arma> Arma { get; set; }
        public virtual ICollection<Semilla> Semilla { get; set; }
    }
}
