using System;

namespace Pattern.Infrastructure.MediatorPattern
{
    public class OutroParticipante : Participante
    {
        public OutroParticipante(string nome) : base(nome)
        {
        }

        public override void Receber(string de, string mensagem)
        {
            Console.WriteLine("De um não ator : ");
            base.Receber(de, mensagem);
        }
    }
}
