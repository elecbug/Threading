internal class Program
{
    private static void Main(string[] args)
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
}