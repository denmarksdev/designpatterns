using Pattern.Domain.Domains.CarroDomain;
using Pattern.Infrastructure.Builder;

namespace Pattern.Infrastructure.Factories
{
    public class CarroFactory
    {
        public Carro Build(CarroBuilder builder)
        {
            builder.SetCavalos();
            builder.SetVelocidade();
            builder.SetNovoRecurso();

            return builder.GetCarro();
        }
    }
}
