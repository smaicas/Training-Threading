namespace Dnj.Training.Threading;
public class ThreadingWithCallback
{
    private readonly string _boilerPlate;
    private readonly int _numberValue;

    // Delegate used to execute the callback method when the
    // task is complete.
    private readonly ExampleCallback _callback;

    public ThreadingWithCallback(string boilerPlate, int numberValue, ExampleCallback callback)
    {
        _boilerPlate = boilerPlate;
        _numberValue = numberValue;
        _callback = callback;
    }

    /// <exception cref="IOException">An I/O error occurred.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="format" /> is <see langword="null" />.</exception>
    /// <exception cref="FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
    public void ThreadProc()
    {
        Console.WriteLine(_boilerPlate, _numberValue);
        if (_callback != null)
            _callback(1);
    }
}
public delegate void ExampleCallback(int lineCount);

