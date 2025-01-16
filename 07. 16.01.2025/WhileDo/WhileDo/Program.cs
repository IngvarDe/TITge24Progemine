namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While and Do");

            int number = 1;

            do
            {
                //peab numbreid n'itama 1-st kuni 5-ni
                Console.WriteLine(number);
                number++;
            }
            while (number <= 5);
        }
    }
}
