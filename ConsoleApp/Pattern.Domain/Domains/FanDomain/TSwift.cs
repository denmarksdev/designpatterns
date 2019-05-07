using Pattern.Domain.Interfaces;

namespace Pattern.Domain.Domains.FanDomain
{
    public class TSwift : ICelebridade
    {
        private delegate void TweetUpdate(ICelebridade celebrity);
        private event TweetUpdate OnTweetUpdate;
        private string _tweet;

        public TSwift(string tweet)
        {
            _tweet = tweet;
        }

        public string Nome => "Taylor Swift";

        public string Tweet
        {
            get => _tweet;
            set =>  Notificar(value);
        }

        public void Notificar(string tweet)
        {
            _tweet = tweet;
            OnTweetUpdate?.Invoke(this);
        }

        public void AdicionaSeguidor(IFan fan)
        {
            OnTweetUpdate += fan.Atualiza;
        }

        public void RemoveSeguidor(IFan fan)
        {
            OnTweetUpdate -= fan.Atualiza;
        }
    }
}
