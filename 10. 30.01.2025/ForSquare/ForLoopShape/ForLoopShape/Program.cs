namespace ForLoopShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta numbripüramiidi suurus");
            Console.WriteLine("-----------------------------------------------------");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------");

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write("{0}", j);
                }

                Console.Write("\n");
            }

        }
    }
}
