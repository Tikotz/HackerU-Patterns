Singelton singelton1 = Singelton.GetInstance();
singelton1.StamMethod();
Thread.Sleep(1000);

Singelton singelton2 = Singelton.GetInstance();
singelton1.StamMethod();

public class Singelton
{
    private static Singelton _instance;
    private long _MyTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    private static object _MyLock = new object();


    private Singelton()
    {

    }

    public static Singelton GetInstance()
    {
        if (_instance == null)
        {
            lock (_MyLock)
            {
                _instance = new Singelton();
            }
        }
        return _instance;
    }

    public void StamMethod()
    {
        Console.WriteLine(_MyTimestamp);
    }
}
