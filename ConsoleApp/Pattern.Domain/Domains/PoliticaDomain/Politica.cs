namespace Pattern.Domain.Domains.PoliticaDomain
{
    public class Politica
    {
        private static readonly object _lock = new object();
        private static Politica _instance;

        public static Politica Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Politica();
                    return _instance;
                }
            }
        }

        private Politica()
        {
        }

        public string GetNomeSegurado => "Denis Marques";
    }
}
