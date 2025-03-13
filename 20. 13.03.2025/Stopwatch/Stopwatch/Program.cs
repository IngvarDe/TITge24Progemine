namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch!");

            System.Diagnostics.Stopwatch stopwatch 
                = new System.Diagnostics.Stopwatch();

            stopwatch.Start();
            Thread.Sleep(10000);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Run time " + elapsedTime);
        }
    }
}
