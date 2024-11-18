using Module;

internal class Program
{
    private static void Main(string[] args)
    {
        var start = Benchmark.Start();
        int sum = 0;

        for (int i = 1; i <= 100000; i++)
        {
            sum += i;
        }

        var span = start.End();

        Console.WriteLine($"Using {span} seconds to add up to 1 to 100,000.");
    }
}