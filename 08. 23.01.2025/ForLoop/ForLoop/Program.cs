namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruudu tegemine");

            Console.WriteLine("Sisesta ruudu suurus");
            int squareSize = Int32.Parse(Console.ReadLine());

            for (int row = 1; row <= squareSize; row++)
            {
                for (int column = 1; column <= squareSize; column++)
                {
                    string variable = (row == column || row + column == squareSize + 1) ? " X " : " 0 ";

                    Console.Write(variable);
                }

                Console.WriteLine();
        }

            Console.ReadKey();
        }
    }
}
