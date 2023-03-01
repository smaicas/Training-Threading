namespace Dnj.Colab.Training.Philosophers;
public class Philosophe
{
    private readonly int _id;
    private readonly Tenedor _tleft;
    private readonly Tenedor _tright;
    public Philosophe(int id, Tenedor tleft, Tenedor tright)
    {
        _id = id;
        _tleft = tleft;
        _tright = tright;
    }

    public async Task Comer(CancellationToken ct = default)
    {
        while (!ct.IsCancellationRequested)
        {
            await Comer();
            //Thread.Sleep(500);
        }
    }

    private async Task Comer()
    {
        //if (_tleft.Disponible && _tright.Disponible)
        //{
        lock (_tleft)
            lock (_tright)
            {
                //if (_t1.Disponible && _t2.Disponible)
                //{
                Console.WriteLine($"El filósofo {_id} está comiendo");
                _tleft.Disponible = false;
                _tright.Disponible = false;
                //Thread.Sleep(2000);
                _tleft.Disponible = true;
                _tright.Disponible = true;
                //}
            }
        //}
        await Task.Delay(100);
    }
}
