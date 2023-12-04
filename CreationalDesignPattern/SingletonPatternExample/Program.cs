//Call the GetInstance static method to get the Singleton Instance
using SingletonPatternExample;

//Singleton fromCoach = Singleton.Instance();
//fromCoach.PrintDetails("From Coach");

//Singleton fromPlayer = Singleton.Instance();
//fromPlayer.PrintDetails("From Player");
//Console.ReadLine();
Parallel.Invoke(() => PrintCoachDetails(),
                () => PrintPlayerDetails());

Console.ReadLine();

static void PrintCoachDetails()
{
    //Thread-1 Calling the GetInstance() Method of the Singleton class
    Singleton fromCoach = Singleton.Instance();
    fromCoach.PrintDetails("From Coach");
}
static void PrintPlayerDetails()
{
    //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
    Singleton fromPlayer = Singleton.Instance();
    fromPlayer.PrintDetails("From Player");
}
