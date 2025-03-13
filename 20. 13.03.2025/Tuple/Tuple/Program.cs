namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuple");

            var humans = System.Tuple.Create(1, "Jaan", "Tallinn");
            //konsool peab näitama sulgude sees olevaid väärtusi
            Console.WriteLine(humans.Item1);
            Console.WriteLine(humans.Item2);
            Console.WriteLine(humans.Item3);

            Console.WriteLine("----------------------------------");
            var numbers = System.Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
        
            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            Console.WriteLine(numbers.Item4);
            Console.WriteLine(numbers.Item5);
            Console.WriteLine(numbers.Item6);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest);
            Console.WriteLine(numbers.Rest.Item1);


            Console.WriteLine("----------------------------------");
            var numbrid = System.Tuple.Create(1, 2, 3, 4, 5, 6, 7,
                System.Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine(numbrid.Item1);
            Console.WriteLine(numbrid.Item7);
            Console.WriteLine(numbrid.Rest.Item1);
            Console.WriteLine(numbrid.Rest.Item1.Item1);
            Console.WriteLine(numbrid.Rest.Item1.Item2);

            int someNumber = 0;

            for (int i = 0; i < someNumber; i++)
            {
                //someNumber = numbrid + (i + 1);
                someNumber = numbrid.Item1 + 1;
                Console.WriteLine(someNumber);
            }
        }
    }
}
