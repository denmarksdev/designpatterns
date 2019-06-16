using Pattern.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Pattern.Domain.Domains.EmpregadosDomain
{
    public class Supervisor : IEmpregado
    {
        public int Id { get ; set ; }
        public string Nome { get ; set ; }
        public int Avaliacao { get ; set ; }

        public List<IEmpregado> Subordinados { get; set; } = new List<IEmpregado>();

        public void ResumoPerformance()
        {
            Console.WriteLine("\nResumo da performance do supervisor:" +
                $"{Nome} é {Avaliacao} de 5");
        }

        public void IncluirSubordinado(IEmpregado empregado) {
            Subordinados.Add(empregado);
        }
    }
}