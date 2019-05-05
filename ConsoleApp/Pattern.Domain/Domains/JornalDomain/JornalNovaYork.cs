using Pattern.Domain.Aggregate;
using Pattern.Domain.Interfaces;
using Pattern.Domain.Iterators;
using System.Collections.Generic;

namespace Pattern.Domain.Domains.JornalDomain
{
    public class JornalNovaYork : IJornal
    {
        private List<string> _reporters;

        public JornalNovaYork()
        {
            _reporters = new List<string>
            {
                "John Mesh - NY",
                "Susanna Lee - NY",
                "Paul Randy - NY",
                "Kim Fields - NY",
                "SKY Taylor - NY"
            };
        }

        public IIterator CreateIterator()
        {
            return new JornalNovaYorkIterator(_reporters);
        }
    }
}
