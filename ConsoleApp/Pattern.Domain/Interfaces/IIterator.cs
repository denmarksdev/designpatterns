namespace Pattern.Domain.Interfaces
{
    public interface IIterator
    {
        void First();    
        string Next();   
        bool IsDone();   
        string CurrentItem();
    }
}
