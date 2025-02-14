namespace ListNumbersMinMaxSumAvarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers");

            int[] numbers = new int[5] { 10, 15, 16, 8, 6 };

            Console.WriteLine("Kõige suurem nr on: " + numbers.Max());
            Console.WriteLine("Kõige väiksem nr on: " + numbers.Min());
            Console.WriteLine("Numbrite koondsumma on: " + numbers.Sum());
            Console.WriteLine("Numbrite keskmine on: " + numbers.Average());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremani");
            //leidke ise vastus
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Sorteerib numbrid alates suuremast väiksemani");
            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine(Array.BinarySearch(numbers, 15));
            //mis tähendab BinarySearch?
        }
    }
}
