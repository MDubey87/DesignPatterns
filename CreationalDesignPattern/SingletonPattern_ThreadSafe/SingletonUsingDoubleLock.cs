using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern_ThreadSafe
{
    public sealed class SingletonUsingDoubleLock
    {
        /// <summary>
        /// To store the Singleton Instance
        /// </summary>
        private static SingletonUsingDoubleLock instance = null;

        /// <summary>
        /// To use the lock, we need to create one variable
        /// </summary>
        private static readonly object Instancelock = new object();

        /// <summary>
        /// Counter value will be increment by 1 each time the object of the class is created
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Private constructor to restrict the class to be instantiated from outside the class
        /// </summary>
        private SingletonUsingDoubleLock()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        /// <summary>
        /// Static Method to return the Singleton Instance
        /// </summary>
        public static SingletonUsingDoubleLock Instance()
        {
            if (instance == null)
            {
                lock (Instancelock)
                {
                    if (instance == null) { instance = new SingletonUsingDoubleLock(); }
                }
            }
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
