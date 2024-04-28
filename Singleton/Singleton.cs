public class Singleton
{
    // this is static because we need to access it even if no instance exists
    static Singleton? singleton { get; set; }
    private string _name { get; set; } = string.Empty;

    private Singleton(string name)
    {
        Console.WriteLine($"Constructing Singleton named: {name}");
        _name = name;
        // we're constructing a new instance, so set the static singleton to this instance
        singleton = this;
    }

    public static Singleton GetSingleton(string name)
    {
        if (singleton != null)
        {
            Console.WriteLine("A Singleton already exists, so returning that one...");
            return singleton;
        }

        Console.WriteLine("No Singleton exists yet, so creating and returning a new one...");
        return new Singleton(name);
    }

    public void WriteName()
    {
        Console.WriteLine($"Hello! My name is {_name}");
    }
}
