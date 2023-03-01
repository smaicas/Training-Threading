namespace Dnj.Training.Threading;
public class ThreadingWithState
{
    private readonly string _boilerPlate;
    private readonly int _numberValue;

    public ThreadingWithState(string boilerPlate, int numberValue)
    {
        _boilerPlate = boilerPlate;
        _numberValue = numberValue;
    }

    /// <exception cref="IOException">An I/O error occurred.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="format" /> is <see langword="null" />.</exception>
    /// <exception cref="FormatException">The format specification in <paramref name="format" /> is invalid.</exception>
    public void ThreadProc() => Console.WriteLine(_boilerPlate, _numberValue);
}
