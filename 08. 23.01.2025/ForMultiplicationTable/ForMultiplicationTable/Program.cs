namespace ForMultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int j, i, n;

            Console.WriteLine("Sisesta tabelisse number, millest soovid alustada");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Korrutustabel ühest kuni {0}", n);
            Console.Write("\n");

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0}x{1} = {2}, ", j, i, i*j);
                    }
                    else
                    {
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    }
                }

                Console.Write("\n");
            }
        }
    }
}
