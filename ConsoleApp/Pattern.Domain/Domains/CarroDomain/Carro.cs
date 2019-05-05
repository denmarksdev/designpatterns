namespace Pattern.Domain.Domains.CarroDomain
{
    public abstract class Carro
    {
        public string Descricao { get; set; }
        public abstract string GetDescricao();
        public abstract double GetPrecoCarro();
    }
}
