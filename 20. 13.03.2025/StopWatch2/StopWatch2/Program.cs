using System.Diagnostics;

namespace StopWatch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch!");
            //siin algab stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //toimub for loop 1000 korda
            //seal sees Sleep(10)
            //prindib välja iga tsükli numbri
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
                Console.WriteLine(i);
            }

            //stopwatch lõppeb ära
            stopwatch.Stop();

            //konsoolis näitab aega
            Console.WriteLine("Kulunud aeg: {0:hh\\:mm\\:ss}",
                stopwatch.Elapsed);
        }
    }
}
