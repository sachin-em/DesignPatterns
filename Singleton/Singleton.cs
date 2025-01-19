public sealed class Singleton {
    private static int _counter = 0;
    private static Singleton _instance = null;
    private static readonly object _lockObject = new object();

    private Singleton()
    {
        _counter++;
        Console.WriteLine($"object created {_counter} times");
    }

    public static Singleton GetInstance() {
        if (_instance == null) {
            lock (_lockObject)
            {
                if (_instance == null) {
                    _instance = new Singleton();
                }
            }
        }
        
        return _instance;
    }

}

