namespace Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas soovid ruutu näha?");
            Console.WriteLine("ei või ja");
            string answer = Console.ReadLine().ToLower();

            if (answer == "ja")
            {
                Square();
            }
            else
            {
                Console.WriteLine("Mingi error");
            }
            //teha ruut ja kasutada for loopi
            //ruudu valmimine toimub teises meetodis
            //main meetodis saab k[sida, et kas soovid v]i mitte ruutu teha


        }

        static void Square()
        {
            Console.WriteLine("Sisesta ruudu suurus");
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "* ";
                    }
                    else
                    {
                        mark = "* ";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}
