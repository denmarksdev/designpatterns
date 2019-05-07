namespace Pattern.Domain.Interfaces
{
    public interface ICelebridade
    {
        string Nome { get;  }
        string Tweet { get; set; }
        void Notificar(string tweet);
        void AdicionaSeguidor(IFan fan);
        void RemoveSeguidor(IFan fan);
    }
}
