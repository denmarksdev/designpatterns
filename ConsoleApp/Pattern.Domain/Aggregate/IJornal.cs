using Pattern.Domain.Interfaces;

namespace Pattern.Domain.Aggregate
{
    public interface IJornal
    {
        IIterator CreateIterator();
    }
}
