using System.Drawing;

namespace SwicthColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Color");

            for (int i = 0; i < 130; i++)
            {
                Colour c = (Colour)(new Random()).Next(0, 5);

                switch (c)
                {
                    case Colour.Red:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("The colour is red");
                        break;
                    case Colour.Green:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("The colour is green");
                        break;
                    case Colour.Blue:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("The colour is blue");
                        break;
                    case Colour.Brown:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                        Console.WriteLine("The colour is brown");
                        break;
                    case Colour.Purple:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.WriteLine("The colour is purple");
                        break;
                    case Colour.White:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("The colour is white");
                        break;
                    default:
                        break;
                }

                Colour colour = (Colour)(new Random()).Next(0, 5);
                Console.WriteLine("The color is {0}", colour);
            }
        }
    }

    public enum Colour
    {
        Red,
        Green,
        Blue,
        Brown,
        Purple,
        White
    }
}
