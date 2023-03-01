namespace Dnj.Colab.Training.Philosophers;
public class Resolver
{
    private static readonly int[] Tenedores = { 1, 1, 1, 1, 1 };
    public static async Task Comer(int left, int right)
    {
        if (Tenedores[left] == 1 && Tenedores[right] == 1)
        {
            Tenedores[left] = 0;
            Tenedores[right] = 0;
            Console.WriteLine($"El filósofo {left + 1} está comiendo");
            await Task.Delay(3000);
            Tenedores[left] = 1;
            Tenedores[right] = 1;
        }
    }
}
