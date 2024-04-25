using Observer.Interfaces;

namespace Observer;

public class Player : IObservedSubject
{
    private List<IObserver> Observers { get; set; } = new List<IObserver>();
    private int Score { get; set; }
    private int Rating { get; set; } = 1;

    public void Register(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void Deregister(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public int GetScore()
    {
        return Score;
    }

    public int GetRating()
    {
        return Rating;
    }

    public void IncreaseLevel()
    {
        Score += 1;
        Rating = Rating * Score;

        foreach (var observer in Observers)
        {
            observer.Update();
        }
    }
}
