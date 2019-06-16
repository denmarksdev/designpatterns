using Pattern.Domain.Domains.EmpregadosDomain;
using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Infrastructure.VisitorPattern
{

    /// <summary>
    /// A 'ConcretVisitor' class
    /// </summary>
    public class VisitanteEntrada : IVisitor
    {
        public void Visitar(Elemento element)
        {
            Empregado empregado = element as Empregado;
            empregado.Entrada *= 1.10;

            Console.WriteLine("{0} {1}'s nova entrada: {2:C}",
                empregado.GetType().Name,
                empregado.Nome,
                empregado.Entrada);
        }
    }
}
