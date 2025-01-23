namespace TriangleForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk tärnidest e poolik püramiid");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            Console.Write("Sisesta ridade arv: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
