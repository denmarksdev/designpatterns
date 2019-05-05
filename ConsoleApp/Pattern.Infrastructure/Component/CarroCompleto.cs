using Pattern.Domain.Domains.CarroDomain;

namespace Pattern.Infrastructure.Component
{
    public class CarroCompleto : Carro
    {
        public CarroCompleto()
        {
            Descricao = "Carro completo";
        }

        public override string GetDescricao() => Descricao;
        public override double GetPrecoCarro() => 300000.00;
    }
}
