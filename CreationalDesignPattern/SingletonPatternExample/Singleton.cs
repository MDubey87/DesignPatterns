namespace SingletonPatternExample
{
    /// <summary>
    /// Sealed class to ensure that it cannot be inherited
    /// </summary>
    public sealed class Singleton
    {
        /// <summary>
        /// To store the Singleton Instance
        /// </summary>
        private static Singleton instance = null;

        /// <summary>
        /// Counter value will be increment by 1 each time the object of the class is created
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Private constructor to restrict the class to be instantiated from outside the class
        /// </summary>
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        /// <summary>
        /// Static Method to return the Singleton Instance
        /// </summary>
        public static Singleton Instance()
        {
            if (instance == null) { instance = new Singleton(); }
            return instance;
        }

        /// <summary>
        /// Method to accessed from outside of the class by using the Singleton Instance
        /// </summary>
        /// <param name="message"></param>
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
