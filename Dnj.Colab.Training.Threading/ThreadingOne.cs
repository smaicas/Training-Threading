namespace Dnj.Training.Threading;
public class ThreadingOne
{
    // The method that will be called when the thread is started.
    public void InstanceMethod()
    {
        Console.WriteLine("Begin Task Instanced 1");

        Thread.Sleep(10000);

        Console.WriteLine("End Task Instanced 1");
    }

    public static void StaticMethod()
    {
        Console.WriteLine("Begin Task Static 2");

        // Pause for a moment to provide a delay to make
        // threads more apparent.
        Thread.Sleep(2000);
        Console.WriteLine("End Task Static 2");
    }
}
