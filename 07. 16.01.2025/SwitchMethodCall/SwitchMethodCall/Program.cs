namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number 1-st kuni 3-ni !");

            //Teha swicth rakendus, kus on mitu
            //case-i meetodi välja kutsumiseks
            //coupe
            //truck
            //buss
            int nr = int.Parse(Console.ReadLine());

            switch (nr)
            {
                case 1:
                    Coupe();
                    break;

                case 2:
                    Truck();
                    break;

                case 3:
                    Buss();
                    break;

                default:
                    Console.WriteLine("Sisestasid mingi imeliku numbri.");
                    break;
            }

        }

        static void Coupe()
        {
            Console.WriteLine("Its a coupee");
        }

        static void Truck()
        {
            Console.WriteLine("Its a truck");
        }

        static void Buss()
        {
            Console.WriteLine("Its a buss");
        }
    }
}
