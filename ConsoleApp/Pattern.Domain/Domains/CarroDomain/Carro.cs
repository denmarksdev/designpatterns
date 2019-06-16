namespace Pattern.Domain.Domains.CarroDomain
{
    public abstract class Carro
    {
        public string Descricao { get; set; }
        public int VelocidadeMPH { get; set; }
        public int Cavalos { get; set; }
        public string NovoRecurso { get; set; }
        public abstract string GetDescricao();
        public abstract double GetPrecoCarro();
    }
}
