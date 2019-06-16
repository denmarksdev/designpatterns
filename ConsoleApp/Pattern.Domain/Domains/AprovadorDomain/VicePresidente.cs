using System;

namespace Pattern.Domain.Domains.AprovadorDomain
{
    public class VicePresidente : Aprovador
    {
        public override void ProcessarRequisicao(Compra compra)
        {
            if (compra.Valor < 50000.0)
            {
                Console.WriteLine("{0} aprovou a requisição# {1}",
                    this.GetType().Name, compra.Numero);
            }
            else if (sucessor != null)
            {
                sucessor.ProcessarRequisicao(compra);
            }
        }
    }
}
