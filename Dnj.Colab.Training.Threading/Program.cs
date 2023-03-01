using Dnj.Training.Threading;

// PRUEBA ASYNCTASKS
//AsyncTasks asyncTaskTest = new();
//await asyncTaskTest.AsyncTasksTest();
//await asyncTaskTest.CompletedOne.Task;
//await asyncTaskTest.CompletedTwo.Task;

// PRUEBA PARALLEL
//ParallelTasks parallelTasksTest = new();
//await parallelTasksTest.ParallelTaskTest();
//await parallelTasksTest.CompletedOne.Task;
//await parallelTasksTest.CompletedTwo.Task;
//await parallelTasksTest.ParallelTaskTest2();

// PRUEBA WHEN ALL
//WhenAllTasks whenAllTasks = new();
//await whenAllTasks.WhenAllTasksTests();
//await whenAllTasks.CompletedAll.Task;

// PRUEBA THREADS
// Prueba 1 : Normal thread
ThreadingOne threadingClass = new();
Thread instanceCaller = new(new ThreadStart(threadingClass.InstanceMethod));
instanceCaller.Start();
Thread staticCaller = new(new ThreadStart(ThreadingOne.StaticMethod));
staticCaller.Start();

// Prueba 2: Thread with parameters/state
ThreadingWithState tws = new("This report displays the number {0}.", 42);
Thread t = new(new ThreadStart(tws.ThreadProc));
t.Start();
Console.WriteLine("Main thread does some work, then waits.");
t.Join();
Console.WriteLine("Independent task has completed; main thread ends.");

// Prueba 3: Thread with callback
ThreadingWithCallback tws2 = new(
    "This report displays the number {0}.",
    42,
    new ExampleCallback(ResultCallback)
);
Thread t2 = new(new ThreadStart(tws2.ThreadProc));
t2.Start();
Console.WriteLine("Main thread does some work, then waits.");
t2.Join();
Console.WriteLine(
    "Independent task has completed; main thread ends.");
// The callback method must match the signature of the
// callback delegate.
static void ResultCallback(int lineCount)
{
    Console.WriteLine(
        "Independent task printed {0} lines.", lineCount);
}