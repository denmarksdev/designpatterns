using Pattern.Domain.Interfaces;

namespace Pattern.Domain.Domains.EmpregadosDomain
{

    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public abstract class Elemento
    {
        public abstract void Aceitar(IVisitor visitor);
    }
}
