using Pattern.Domain.Domains.CarroDomain;

namespace Pattern.Infrastructure.Builder
{
    public class SuperCarroBuilder : CarroBuilder
    {
        public SuperCarroBuilder(Carro carro) : base(carro)
        {
        }

        public override void SetCavalos()
        {
            _carro.Cavalos = 1640;
        }

        public override void SetNovoRecurso()
        {
            _carro.NovoRecurso = "Pode voar";
        }

        public override void SetVelocidade()
        {
            _carro.VelocidadeMPH = 600;
        }
    }
}
