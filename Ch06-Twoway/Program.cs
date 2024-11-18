internal class Program
{
    private static void Main(string[] args)
    {
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Now 'i' is {i}");

                Task.Delay(1000).Wait();
            }
        });

        Thread t2 = new Thread(() =>
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Now 'j' is {j}");

                Task.Delay(1000).Wait();
            }
        });

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }
}