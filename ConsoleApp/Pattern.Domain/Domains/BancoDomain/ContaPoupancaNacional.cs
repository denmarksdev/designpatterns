using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Domain.BankDomain
{
    public class ContaPoupancaNacional : ContaPoupancaBase , IContaPoupanca
    {
        public ContaPoupancaNacional()
        {
            Console.WriteLine("Retorna uma Conta poupança Nacional");

            Saldo = 2000;
        }
    }
}
