using System;

namespace Pattern.Infrastructure.MediatorPattern
{

    /// <summary>
    /// The 'AbstractCollegue' class
    /// </summary>
    public class Participante
    {
        private string _nome;

        public Participante(string nome)
        {
            _nome = nome;
        }

        public string Nome => _nome;

        public SalaBatePapo SalaBatePapo { get; set; }


        public void Enviar(string para, string  mensagem) {

            SalaBatePapo.Enviar(_nome, para, mensagem);
        }

        public virtual void Receber(string para, string mensagem ) {
            Console.WriteLine("{0} para {1}: {2}", para, _nome, mensagem);
        }

    }
}