using Observer.Interfaces;

namespace Observer;

public class ScoreWatcher : IObserver
{
    private IObservedSubject _player;

    public ScoreWatcher(IObservedSubject player)
    {
        _player = player;
        player.Register(this);
    }

    public void update()
    {
        var latestScore = _player.GetScore();
        Console.WriteLine($"ScoreWatcher: The score is now {latestScore}");
    }
}
