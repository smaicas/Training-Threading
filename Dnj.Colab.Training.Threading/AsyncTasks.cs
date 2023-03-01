namespace Dnj.Training.Threading;
public class AsyncTasks
{
    public TaskCompletionSource<bool> CompletedOne = new();
    public TaskCompletionSource<bool> CompletedTwo = new();
    public async Task AsyncTasksTest()
    {
        Task.Run(ActionOne);
        Task.Run(ActionTwo);
    }

    private async Task? ActionTwo()
    {
        Console.WriteLine("Begin Task 2");
        await Task.Delay(2000);
        Console.WriteLine("End Task 2");
        CompletedTwo.SetResult(true);
    }

    private async Task? ActionOne()
    {
        Console.WriteLine("Begin Task 1");
        await Task.Delay(10000);
        Console.WriteLine("End Task 1");
        CompletedOne.SetResult(true);
    }
}
