using Pattern.Domain.Interfaces;

namespace Pattern.Interfaces.Bases
{
    public abstract class CreditoUnionBase
    {
        public abstract IContaPoupanca CriarContaPoupanca();
        public abstract IContaEmprestimo CriarContaEmprestimo();
    }
}
