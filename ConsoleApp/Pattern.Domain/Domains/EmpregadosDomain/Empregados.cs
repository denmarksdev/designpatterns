using Pattern.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Pattern.Domain.Domains.EmpregadosDomain
{
    public class Empregados
    {
        private List<Empregado> _empregados = new List<Empregado>();

        public void Anexar(Empregado empregado)
        {
            _empregados.Add(empregado);
        }

        public void Desanexar(Empregado empregado)
        {
            _empregados.Remove(empregado);
        }

        public void Aceitar(IVisitor visitor)
        {
            foreach (var empregado in _empregados)
            {
                empregado.Aceitar(visitor);
            }
            Console.WriteLine();
        }
    }
}