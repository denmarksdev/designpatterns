using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Domain.BankDomain
{
    public class ContaEmprestimoNacional : IContaEmprestimo
    {
        public ContaEmprestimoNacional()
        {
            Console.WriteLine("Retorna uma Conta Nacional de Empréstimo ");
        }
    }
}
