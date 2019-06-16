using System.Collections.Generic;

namespace Pattern.Infrastructure.MediatorPattern
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public class SalaBatePapo : SalaBatePapoAbstract
    {

        private Dictionary<string, Participante> _participantes =
                new Dictionary<string, Participante>();

        public override void Enviar(string from, string to, string message)
        {
            Participante participante = _participantes[to];
            if (participante != null)
            {
                participante.Receber(from, message);
            }
        }

        public override void Registrar(Participante participante)
        {
            if (!_participantes.ContainsValue(participante))
            {
                _participantes[participante.Nome] = participante;
            }

            participante.SalaBatePapo = this;
        }
    }
}
