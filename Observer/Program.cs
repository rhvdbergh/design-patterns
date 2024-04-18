using Observer;

var player = new Player();
var scoreWatcher = new ScoreWatcher(player);
var ratingsWatcher = new RatingsWatcher(player);

player.IncreaseLevel();
player.IncreaseLevel();
player.IncreaseLevel();
player.IncreaseLevel();

player.Deregister(scoreWatcher);

player.IncreaseLevel();
