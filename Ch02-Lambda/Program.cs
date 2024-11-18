using Module;

internal class Program
{
    private static void Main(string[] args)
    {
        var span = Benchmark.Run(() =>
        {
            int sum = 0;

            for (int i = 1; i <= 100000; i++)
            {
                sum += i;
            }
        });

        Console.WriteLine($"Using {span} seconds to add up to 1 to 100,000.");
    }
}