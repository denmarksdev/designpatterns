using Pattern.Domain.Domains.EmpregadosDomain;

namespace Pattern.Domain.Interfaces
{
    public interface IVisitor
    {
        void Visitar(Elemento element);
    }
}
