using Observer.Interfaces;

namespace Observer;

public class RatingsWatcher : IObserver
{
    private IObservedSubject _player;

    public RatingsWatcher(IObservedSubject player)
    {
        _player = player;
        player.Register(this);
    }

    public void update()
    {
        var latestRating = _player.GetRating();
        Console.WriteLine($"RatingsWatcher: The rating is now {latestRating}");
    }
}
