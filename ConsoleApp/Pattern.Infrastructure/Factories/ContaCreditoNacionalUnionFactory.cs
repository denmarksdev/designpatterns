using Pattern.Domain.BankDomain;
using Pattern.Domain.Interfaces;
using Pattern.Interfaces.Bases;

namespace Pattern.Infrastructure.Factories
{
    public class ContaCreditoNacionalUnionFactory : CreditoUnionBase
    {
        public override IContaEmprestimo CriarContaEmprestimo()
        {
            return new ContaEmprestimoNacional();
        }

        public override IContaPoupanca CriarContaPoupanca()
        {
            return new ContaPoupancaNacional();
        }
    }
}
