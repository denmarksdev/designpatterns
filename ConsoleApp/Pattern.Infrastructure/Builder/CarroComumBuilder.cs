using Pattern.Domain.Domains.CarroDomain;

namespace Pattern.Infrastructure.Builder
{
    public class CarroComumBuilder : CarroBuilder
    {
        public CarroComumBuilder(Carro carro) : base(carro)
        {
        }

        public override void SetCavalos()
        {
            _carro.Cavalos = 120;
        }

        public override void SetNovoRecurso()
        {
            _carro.NovoRecurso = "Tem ar condicionado.";
        }

        public override void SetVelocidade()
        {
            _carro.VelocidadeMPH = 70;
        }
    }
}
