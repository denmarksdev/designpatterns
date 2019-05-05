using Pattern.Domain.Aggregate;
using Pattern.Domain.Interfaces;
using Pattern.Domain.Iterators;

namespace Pattern.Domain.Domains.JornalDomain
{
    public class JornalLosAngeles : IJornal
    {
        private string[] _reporters;

        public JornalLosAngeles()
        {
            _reporters = new[]
            {
                "Ronal Smith - La",
                "Dany Glover - La",
                "Yolanda Adams - La",
                "Jerry Straight - La",
                "Rhonda Lime - La",
            };
        }

        public IIterator CreateIterator()
        {
            return new JornalLosAngelesIterator(_reporters);
        }
    }
}
