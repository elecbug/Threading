namespace InSpan
{
    public class Benchmark
    {
        private DateTime _start;
        
        private Benchmark()
        {
            _start = DateTime.Now;
        }

        public static Benchmark Start()
        {
            return new Benchmark();
        }

        public double End()
        {
            return (DateTime.Now - _start).TotalSeconds;
        }

        public static double Run(Action action)
        {
            var start = DateTime.Now;

            action();

            return (DateTime.Now - start).TotalSeconds;
        }
    }
}
