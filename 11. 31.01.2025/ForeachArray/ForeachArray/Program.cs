namespace ForeachArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] myArray = { "H", "e", "l", "l", "o" };

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
