using Pattern.Domain.Domains.CarroDomain;
using Pattern.Infrastructure.Decorator;

namespace Pattern.Infrastructure.ConcretDecorator
{
    public class AssentosCouro : CarroDecorator
    {
        public AssentosCouro(Carro carro) : base(carro)
        {
            Descricao = "Assentos de couro";
        }

        public override string GetDescricao() => $"{_carro.GetDescricao()},  {Descricao}";

        public override double GetPrecoCarro() => _carro.GetPrecoCarro() + 2500;
    }
}
