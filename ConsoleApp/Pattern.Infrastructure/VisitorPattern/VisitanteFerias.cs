using Pattern.Domain.Domains.EmpregadosDomain;
using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Infrastructure.VisitorPattern
{
    public class VisitanteFerias : IVisitor
    {
        public void Visitar(Elemento element)
        {
            Empregado empregado = element as Empregado;

            empregado.DiasFerias += 3;
            Console.WriteLine("{0} {1}'s novos dias de férias: {2}",
                empregado.GetType().Name, empregado.Nome, empregado.DiasFerias);
        }
    }
}
