internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Now 'i' is {i}");

            Task.Delay(1000).Wait();
        }

        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine($"Now 'j' is {j}");

            Task.Delay(1000).Wait();
        }
    }
}