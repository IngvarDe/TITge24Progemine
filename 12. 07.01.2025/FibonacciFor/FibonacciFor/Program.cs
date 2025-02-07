namespace FibonacciFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Display the first n terms of Fibonacci series:\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Input number of terms to be displayed: ");
            
            int prv = 0, pre = 1, trm, i, n;
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}   {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
        }
    }
}
