//namespace PhilosopherLunch;

//public static class Program
//{
//    public static void Main(string[] args)
//    {
//        //TaskCompletionSource<bool> cs  = new TaskCompletionSource<bool>();
//        Fork[] forks = new Fork[]
//        {
//            new Fork(),
//            new Fork(),
//            new Fork(),
//            new Fork(),
//            new Fork(),
//        };

//        Philosopher[] philosophers = new Philosopher[]
//        {
//            new Philosopher("Pato", forks[0], forks[1], 10),
//            new Philosopher("Nietche", forks[1], forks[2], 10),
//            new Philosopher("Descartes", forks[2], forks[3], 10),
//            new Philosopher("Socrates", forks[3], forks[4], 10),
//            new Philosopher("Aristoteles", forks[4], forks[0], 10),
//        };

//        foreach (Philosopher philosopher in philosophers)
//        {
//            Task.Run(() => philosopher.EatUntilFull());
//        }

//        while (philosophers.Any(p => p.Full == false))
//        {
//            Thread.Sleep(2000);
//        }

//    }
//}

//public class Fork
//{
//    public bool Disponible { get; set; } = true;
//}

//public class Philosopher
//{
//    private readonly string _name;
//    private readonly Fork _leftFork;
//    private readonly Fork _rightFork;
//    private int _hunger;

//    public bool Full { get; set; }

//    public Philosopher(string name, Fork leftFork, Fork rightFork, int hunger)
//    {
//        _name = name;
//        _leftFork = leftFork;
//        _rightFork = rightFork;
//        _hunger = hunger;
//    }

//    public void Eat()
//    {
//        lock (_leftFork)
//            lock (_rightFork)
//            {
//                Console.WriteLine($"Philosopher {_name} eating {_hunger}");
//                //_leftFork.Disponible = false;
//                //_rightFork.Disponible = false;
//                Thread.Sleep(2000);
//                //_leftFork.Disponible = true;
//                //_rightFork.Disponible = true;
//                _hunger--;
//                //Console.WriteLine($"Philosopher {_name} ends eating");
//            }
//    }

//    public void EatUntilFull()
//    {
//        Full = false;
//        while (_hunger > 0)
//        {
//            Eat();
//            Thread.Sleep(100);
//        }

//        Full = true;
//    }
//}