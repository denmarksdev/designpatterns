using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Domain.BankDomain
{
    public class ContaCityEmprestimo : IContaEmprestimo
    {
        public ContaCityEmprestimo()
        {
            Console.WriteLine("Returna uma Conta City de Empréstimo");
        }
    }
}
