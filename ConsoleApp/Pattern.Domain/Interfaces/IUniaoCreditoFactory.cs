using Pattern.Domain.BankDomain;

namespace Pattern.Domain.Interfaces
{
    public interface IUniaoCreditoFactory
    {
        ContaPoupancaBase GetContaPoupanca(string numeroConta);
    }
}
