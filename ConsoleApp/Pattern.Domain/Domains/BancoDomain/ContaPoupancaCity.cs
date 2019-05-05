using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Domain.BankDomain
{
    public class ContaPoupancaCity : ContaPoupancaBase, IContaPoupanca
    {
        public ContaPoupancaCity()
        {
            Console.WriteLine("Retorna uma Conta Poupança City");
            Saldo = 5000;
        }
    }
}