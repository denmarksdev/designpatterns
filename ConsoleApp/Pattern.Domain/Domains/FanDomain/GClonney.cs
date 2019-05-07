using Pattern.Domain.Interfaces;
using System.Collections.Generic;

namespace Pattern.Domain.Domains.FanDomain
{
    public class GClonney : ICelebridade
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;

        public GClonney(string tweet)
        {
            _tweet = tweet;
        }

        public string Nome => "George Clooney";
        public string Tweet {

            get => _tweet;
            set => Notificar(_tweet);
        }

        public void AdicionaSeguidor(IFan fan)
        {
            _fans.Add(fan);
        }

        public void Notificar(string tweet)
        {
            _tweet = tweet;
            _fans.ForEach(f => f.Atualiza(this));
        }

        public void RemoveSeguidor(IFan fan)
        {
            _fans.Remove(fan);
        }
    }
}
