using System;

namespace Pattern.Domain.Domains.AprovadorDomain
{
    public class Presidente : Aprovador
    {
        public override void ProcessarRequisicao(Compra compra)
        {
            if (compra.Valor < 10000000.0)
            {
                Console.WriteLine("{0} aprovou a requisição# {1}",
                    this.GetType().Name, compra.Numero);
            }
            else 
            {
                Console.WriteLine("Requisição# {0} prescisa de um encontro executivo!.",
                    this.GetType().Name, compra.Numero);
            }
        }
    }
}
