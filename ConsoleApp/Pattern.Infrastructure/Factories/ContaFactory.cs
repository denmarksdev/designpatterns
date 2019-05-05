using Pattern.Domain.BankDomain;
using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Infrastructure
{
    public class ContaFactory : IUniaoCreditoFactory
    {
        public ContaPoupancaBase GetContaPoupanca(string numeroConta)
        {
            if (numeroConta.Contains("CITY")) return new ContaPoupancaCity();
            if (numeroConta.Contains("NACIONAL")) return new ContaPoupancaNacional();

            throw new ArgumentException("Número da conta inválido");
        }
    }
}
