namespace Observer.Interfaces;

public interface IObservedSubject
{
    public void Register(IObserver observer);
    public void Deregister(IObserver observer);
    public int GetScore();
    public int GetRating();
}
