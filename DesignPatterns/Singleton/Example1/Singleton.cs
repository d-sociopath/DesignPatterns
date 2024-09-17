namespace DesignPatterns.Singleton.Example1
{
    public sealed class Singleton
    {
        private static int Counter = 0;

        private static Singleton instance;

        private static readonly object instanceLock = new object();

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
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
