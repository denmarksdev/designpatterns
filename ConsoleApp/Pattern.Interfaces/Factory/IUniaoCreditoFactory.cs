using Pattern.Domain.BankDomain;

namespace Pattern.Interfaces.Factory
{
    public interface IUniaoCreditoFactory
    {
        ContaPoupancaBase GetContaPoupanca(string numeroConta);
    }
}
