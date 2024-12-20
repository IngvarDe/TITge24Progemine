namespace InsertNrForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta tärnide arv");
            Console.WriteLine("Kasutan selle jaoks for loopi");

            int number = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
        }
    }
}
