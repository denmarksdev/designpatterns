using System;

namespace Pattern.Infrastructure.MediatorPattern
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class Ator : Participante
    {
        public Ator(string nome) : base(nome)
        {
        }

        public override void Receber(string de, string mensagem)
        {
            Console.WriteLine("De um Ator: ");
            base.Receber(de, mensagem);
        }
    }
}