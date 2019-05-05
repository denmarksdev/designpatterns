using Pattern.Domain.Interfaces;

namespace Pattern.Domain.Iterators
{
    public class JornalLosAngelesIterator : IIterator
    {
        private string[] _reporters;
        private int _currentIndex;
        public JornalLosAngelesIterator(string[] reporters )
        {
            _reporters = reporters;
            _currentIndex = 0;
        }

        public string CurrentItem()
        {
            return _reporters[_currentIndex];
        }

        public void First()
        {
            _currentIndex = 0;
        }

        public bool IsDone()
        {
           return _currentIndex >= _reporters.Length;
        }

        public string Next()
        {
            return _reporters[_currentIndex++];
        }
    }
}
