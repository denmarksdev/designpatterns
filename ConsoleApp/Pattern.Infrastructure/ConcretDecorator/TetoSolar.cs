using Pattern.Domain.Domains.CarroDomain;
using Pattern.Infrastructure.Decorator;

namespace Pattern.Infrastructure.ConcretDecorator
{
    public class TetoSolar : CarroDecorator
    {
        public TetoSolar(Carro carro) : base(carro)
        {
            Descricao =  "\nCarro com teto solar";
        }

        public override string GetDescricao() => $"{_carro.Descricao},  {Descricao}";

        public override double GetPrecoCarro() => _carro.GetPrecoCarro() + 10000;
    }
}
