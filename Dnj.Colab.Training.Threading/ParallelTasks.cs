namespace Dnj.Training.Threading;
public class ParallelTasks
{
    public TaskCompletionSource<bool> CompletedOne = new();
    public TaskCompletionSource<bool> CompletedTwo = new();
    public async Task ParallelTaskTest()
    {
        List<Task> tasks = new()
        {
            ActionOne(),
            ActionTwo()
        };
        Parallel.ForEach(tasks, task => Task.FromResult(task));
    }

    public async Task ParallelTaskTest2()
    {
        List<Tuple<int, int>> list = new()
        {
            new(1, 5),
            new(3, 7),
            new(1, 9)
        };
        Parallel.ForEach(list, tuple => Sumar(tuple.Item1, tuple.Item2).Wait());
    }

    private async Task Sumar(int x, int y) => Console.WriteLine(x + y);

    private async Task ActionTwo()
    {
        Console.WriteLine("Begin Task 2");
        await Task.Delay(2000);
        Console.WriteLine("End Task 2");
        CompletedTwo.SetResult(true);
    }

    private async Task ActionOne()
    {
        Console.WriteLine("Begin Task 1");
        await Task.Delay(10000);
        Console.WriteLine("End Task 1");
        CompletedOne.SetResult(true);
    }
}
