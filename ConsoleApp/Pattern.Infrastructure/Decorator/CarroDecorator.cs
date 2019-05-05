using Pattern.Domain.Domains.CarroDomain;

namespace Pattern.Infrastructure.Decorator
{
    public class CarroDecorator : Carro
    {
        protected Carro _carro;
        public CarroDecorator(Carro carro)
        {
            _carro = carro;
        }

        public override string GetDescricao() => _carro.GetDescricao();
        public override double GetPrecoCarro() => _carro.GetPrecoCarro();
    }
}
