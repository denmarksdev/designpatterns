using Pattern.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Pattern.Domain.Iterators
{
    public class JornalNovaYorkIterator : IIterator
    {
        private List<string> _reporters;
        private int _currentIndex;
        
        public JornalNovaYorkIterator(List<string> reporters)
        {
            _reporters = reporters;
            _currentIndex = 0;
        }

        public string CurrentItem()
        {
            return _reporters.ElementAt(_currentIndex);
        }

        public void First()
        {
            _currentIndex = 0;
        }

        public bool IsDone()
        {
            return _currentIndex >= _reporters.Count;
        }

        public string Next()
        {
            return _reporters.ElementAt(_currentIndex++);
        }
    }
}