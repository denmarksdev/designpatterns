using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Domain.Domains.EmpregadosDomain
{
    public class Empregado : Elemento, IEmpregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Avaliacao { get; set; }
        public double Entrada { get; set; }
        public int DiasFerias { get; set; }

        public Empregado()
        {
        }

        public Empregado(string nome, double entrada, int diasFerias)
        {
            Nome = nome;
            Entrada = entrada;
            DiasFerias = diasFerias;
        }

        public override void Aceitar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }

        public void ResumoPerformance()
        {
            Console.WriteLine("\nResumo da performance do empregado:" +
                $"{Nome} é {Avaliacao} de 5");
        }
    }
}
