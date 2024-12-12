namespace RectangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ristküliku pindala ja ümbermõõt!");

            Console.WriteLine("Enter first value");
            string firstNumber = Console.ReadLine();
            float floatFirst = float.Parse(firstNumber);

            Console.WriteLine("Enter second value");
            string secondNumber = Console.ReadLine();
            float floatSecond = float.Parse(secondNumber);

            //teha pindala ja ümbermõõdu kalkulatsioon
            Console.WriteLine("Ümbermõõt " + 2 * (floatFirst + floatSecond));
            Console.WriteLine("Pindala " + (floatFirst * floatSecond));
            Console.ReadKey();
        }
    }
}
