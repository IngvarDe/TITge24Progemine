namespace StringIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //peab saama sisestada nime
            //if ja else kontrollib, kas on nimi või on tühi
            //kui leiate kuskilt teksti värviliseks teha, siis kasutage
            Console.WriteLine("Sisesta nimi ja vajuta enter");
            string firstName = Console.ReadLine();

            if (firstName != "")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Tere " + firstName);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }
    }
}
