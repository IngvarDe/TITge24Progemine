namespace ForeachList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach List");

            List<int> numbers = new List<int>() {5, -8, 3, 14, 9, 17, 0, 4 };
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Sum {0}", sum);
            Console.ReadLine();
        }
    }
}
