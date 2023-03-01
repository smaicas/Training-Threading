
using Dnj.Colab.Training.Philosophers;

Tenedor t0 = new();
Tenedor t1 = new();
Tenedor t2 = new();
Tenedor t3 = new();
Tenedor t4 = new();

TaskCompletionSource<bool> end = new(false);

Philosophe f0 = new(0, t0, t1);
Philosophe f1 = new(1, t1, t2);
Philosophe f2 = new(2, t2, t3);
Philosophe f3 = new(3, t3, t4);
Philosophe f4 = new(4, t4, t0);
//while (true)
//{
Task.Run(() => f0.Comer());
Task.Run(() => f1.Comer());
Task.Run(() => f2.Comer());
Task.Run(() => f3.Comer());
Task.Run(() => f4.Comer());
//}

await end.Task;
