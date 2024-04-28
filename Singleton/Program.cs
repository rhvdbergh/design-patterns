// illustrates the basic Singleton pattern, but with a name
// this is NOT thread safe! it's just to illustrate how the basic pattern works

var singleton = Singleton.GetSingleton("First");
singleton.WriteName();

var anotherSingleton = Singleton.GetSingleton("Second");
anotherSingleton.WriteName();

// neither of these will work, since there is no public constructor!
// var newSingleton = new Singleton("Third");
// var yetAnotherSingleton = new Singleton();
