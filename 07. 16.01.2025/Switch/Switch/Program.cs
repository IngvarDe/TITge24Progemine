namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch, sisesta number");

            //tuleb kasutada switchi
            //esimese case puhul on number vahemikus
            //0 kuni 100,
            //Teise puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300

            string number = Console.ReadLine();
            int nr = int.Parse(number);

            switch (nr)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Valisid 0-st kuni 100-ni");
                    break;
                case >= 101 and <= 200:
                    Console.WriteLine("Valisid 101-st kuni 200-ni");
                    break;
                case >= 201 and <= 300:
                    Console.WriteLine("Valisid 201-st kuni 300-ni");
                    break;

                default:
                    Console.WriteLine("Valisid suurema, kui 301");
                    break;
            }
        }
    }
}
