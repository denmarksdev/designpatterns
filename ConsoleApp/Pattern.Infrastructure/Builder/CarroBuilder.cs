using Pattern.Domain.Domains.CarroDomain;

namespace Pattern.Infrastructure.Builder
{
    public abstract class CarroBuilder
    {
        protected readonly Carro _carro;
        public abstract void SetCavalos();
        public abstract void SetVelocidade();
        public abstract void SetNovoRecurso();

        public CarroBuilder(Carro carro)
        {
            _carro = carro;
        }

        public virtual Carro GetCarro()
        {
            return _carro;
        }
    }
}
