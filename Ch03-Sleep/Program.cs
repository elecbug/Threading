internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Now 'i' is {i}");

            Task.Delay(1000).Wait();
        }
    }
}