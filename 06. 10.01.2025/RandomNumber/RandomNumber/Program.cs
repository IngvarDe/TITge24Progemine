namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //randomina annab meile numbreid vahemikus 1 kuni 6

            int number = new Random().Next(1, 7);

            //nüüd tuleb kasutada switchi, et näidata numbrit 1-st kuni 6-i

            switch (number)
            {
                case 1:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 2:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 3:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 4:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 5:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                case 6:
                    Console.WriteLine("Veeretasid nr " + number);
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
