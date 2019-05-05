using Pattern.Domain.Domains.CarroDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Infrastructure.Component
{
    public class CarroCompacto : Carro
    {
        public CarroCompacto()
        {
            Descricao = "Carro compacto";
        }

        public override string GetDescricao() => Descricao;
        public override double GetPrecoCarro() => 10000.00;
    }
}
