namespace Pattern.Domain.Domains.AprovadorDomain
{
    public class Compra
    {
        public Compra(int numero, double quantidade, string proposito)
        {
            Numero = numero;
            Valor = quantidade;
            Proposito = proposito;
        }

        public int Numero { get; }
        public double Valor { get; }
        public string Proposito { get; }
    }
}