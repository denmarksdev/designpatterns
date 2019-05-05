using Pattern.Domain.Domains.CarroDomain;
using Pattern.Infrastructure.Decorator;

namespace Pattern.Infrastructure.ConcretDecorator
{
    public class Navegacao : CarroDecorator
    {
        public Navegacao(Carro carro) : base(carro)
        {
            Descricao = "Carro com sistema de navegação";
        }

        public override string GetDescricao() => $"{_carro.Descricao},  {Descricao}";

        public override double GetPrecoCarro() => _carro.GetPrecoCarro() + 5000;


    }
}
