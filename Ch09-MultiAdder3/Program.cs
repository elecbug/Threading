using Module;

internal class Program
{
    private static void NoThreading()
    {
        int sum = 0;

        for (int i = 0; i < 100; i++)
        {
            for (int s = 0; s < 10000; s++)
            {
                sum++;
            }
        }

        Console.WriteLine($"Latest 'sum' is {sum}");
    }

    private static void NoLockingThreading()
    {
        int sum = 0;

        Thread[] ts = new Thread[100];

        for (int i = 0; i < ts.Length; i++)
        {
            ts[i] = new Thread(() =>
            {
                for (int s = 0; s < 10000; s++)
                {
                    sum++;
                }
            });
        }

        for (int i = 0; i < ts.Length; i++)
        {
            ts[i].Start();
        }

        for (int i = 0; i < ts.Length; i++)
        {
            ts[i].Join();
        }

        Console.WriteLine($"Latest 'sum' is {sum}");
    }

    private static void LockingThreading()
    {
        int sum = 0;
        object locker = new object();

        Thread[] ts = new Thread[100];

        for (int i = 0; i < ts.Length; i++)
        {
            ts[i] = new Thread(() =>
            {
                for (int s = 0; s < 10000; s++)
                {
                    lock (locker)
                    {
                        sum++;
                    }
                }
            });
        }

        for (int i = 0; i < ts.Length; i++)
        {
            ts[i].Start();
        }

        for (int i = 0; i < ts.Length; i++)
        {
            ts[i].Join();
        }

        Console.WriteLine($"Latest 'sum' is {sum}");
    }

    private static void Main(string[] args)
    {
        double normal = Benchmark.Run(NoThreading);
        Console.WriteLine($"Do not use threading:           {normal} secs");
        
        double noLocking = Benchmark.Run(NoLockingThreading);
        Console.WriteLine($"Use threading without locking:  {noLocking} secs");

        double locking = Benchmark.Run(LockingThreading);
        Console.WriteLine($"Use threading with locking:     {locking} secs");
    }
}