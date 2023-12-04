#region Singleton Using Lock Example
using SingletonPattern_ThreadSafe;
Parallel.Invoke(() => PrintCoachDetails(),
                () => PrintPlayerDetails());

Console.ReadLine();
static void PrintCoachDetails()
{
    //Thread-1 Calling the Instance() Method of the Singleton class
    SingletonUsingLock fromCoach = SingletonUsingLock.Instance();
    fromCoach.PrintDetails("From Coach");
}
static void PrintPlayerDetails()
{
    //At the same time, Thread-2 also Calling the Instance() Method of the Singleton Class
    SingletonUsingLock fromPlayer = SingletonUsingLock.Instance();
    fromPlayer.PrintDetails("From Player");
}
#endregion
#region Singleton Using Double checked Lock Example
Parallel.Invoke(() => PrintCoachDetails1(),
                () => PrintPlayerDetails1());

Console.ReadLine();
static void PrintCoachDetails1()
{
    //Thread-1 Calling the Instance() Method of the Singleton class
    SingletonUsingDoubleLock fromCoach = SingletonUsingDoubleLock.Instance();
    fromCoach.PrintDetails("From Coach");
}
static void PrintPlayerDetails1()
{
    //At the same time, Thread-2 also Calling the Instance() Method of the Singleton Class
    SingletonUsingDoubleLock fromPlayer = SingletonUsingDoubleLock.Instance();
    fromPlayer.PrintDetails("From Player");
}
#endregion

