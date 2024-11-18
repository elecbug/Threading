internal class Program
{
    private static void Main(string[] args)
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Hello, thread!");
        });

        thread.Start();
        thread.Join();

        int now = 0;

        Thread join = new Thread(() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                now = i;
            }
        });

        join.Start();
        // join.Join();

        Console.WriteLine($"Lastest 'now' is {now}");
    }
}