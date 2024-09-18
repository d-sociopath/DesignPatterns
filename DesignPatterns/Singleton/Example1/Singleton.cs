namespace DesignPatterns.Singleton.Example1
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        private static Singleton instance;
        private static readonly object instanceLock = new object();
        private static readonly Lazy<Singleton> inst = new Lazy<Singleton>(() => new Singleton());

        //without lazy initialization
        public static Singleton GetInstance()
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }

        //with lazy initialization
        public static Singleton Instance
        {
            get
            {
                return inst.Value;
            }
        }

        private Singleton()
        {
            Counter++;
            Console.WriteLine($"Counter value {Counter.ToString()}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
