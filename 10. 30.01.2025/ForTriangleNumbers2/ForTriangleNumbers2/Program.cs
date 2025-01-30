namespace ForTriangleNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;

            Console.WriteLine("Sisesta ridadae arv!");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", i);
                }
                Console.WriteLine();
            }
            //vooskeem teha
        }
    }
}
