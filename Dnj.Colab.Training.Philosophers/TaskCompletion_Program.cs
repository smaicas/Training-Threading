//TaskCompletionSource<bool> end = new();

//TaskCompletionSource<bool> t0Disponible = new();
//TaskCompletionSource<bool> t1Disponible = new();
//TaskCompletionSource<bool> t2Disponible = new();
//TaskCompletionSource<bool> t3Disponible = new();
//TaskCompletionSource<bool> t4Disponible = new();

//t0Disponible.SetResult(true);
//t1Disponible.SetResult(true);

//Filosofo p0 = new(1);
//Filosofo p1 = new(2);
//Filosofo p2 = new(3);
//Filosofo p3 = new(4);
//Filosofo p4 = new(5);

//Task.Run(() => p0.Comer(t0Disponible, t1Disponible));
//Task.Run(() => p1.Comer(t1Disponible, t2Disponible));
//Task.Run(() => p2.Comer(t2Disponible, t3Disponible));
//Task.Run(() => p3.Comer(t3Disponible, t4Disponible));
//Task.Run(() => p4.Comer(t4Disponible, t0Disponible));

//await end.Task;

//public class Filosofo
//{
//    private readonly int id;
//    public Filosofo(int id) => this.id = id;

//    public async Task Comer(TaskCompletionSource<bool> t0Disponible, TaskCompletionSource<bool> t1Disponible)
//    {
//        while (true)
//        {
//            await t0Disponible.Task;
//            await t1Disponible.Task;
//            t0Disponible.SetResult(false);
//            t1Disponible.SetResult(false);
//            Console.WriteLine($"Filósofo {id} come hijo de puta");
//            await Task.Delay(2000);
//            t0Disponible.SetResult(true);
//            t1Disponible.SetResult(true);

//        }

//    }
//}