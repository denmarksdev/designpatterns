namespace Pattern.Infrastructure.MediatorPattern
{

    /// <summary>
    /// The ''Mediator' abstract class
    /// </summary>
    public abstract class SalaBatePapoAbstract 
    {
        public abstract void Registrar(Participante participante);
        public abstract void Enviar(string from, string to, string message);
    }
}