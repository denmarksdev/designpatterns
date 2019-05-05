using Pattern.Domain.BankDomain;
using Pattern.Domain.Interfaces;
using Pattern.Interfaces.Bases;

namespace Pattern.Infrastructure.Factories
{
    public class ContaCreditoCityUnionFactory : CreditoUnionBase
    {
        public override IContaEmprestimo CriarContaEmprestimo()
        {
            return new ContaCityEmprestimo();
        }

        public override IContaPoupanca CriarContaPoupanca()
        {
            return new ContaPoupancaCity();
        }
    }
}
