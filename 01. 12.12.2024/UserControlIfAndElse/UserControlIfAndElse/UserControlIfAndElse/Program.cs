namespace UserControlIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kasutaja kontroll");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(" Hello {0}, you are {1} years old.", name, age);
            Console.WriteLine(" Hello " + name + ", you are " + age + " years old.");

            Console.ReadKey();

            if (age < 7 && age > 0)
            {
                Console.WriteLine("Loodan, et käid juba koolis");
            }
            else if (age >= 7 && age <= 18)
            {
                Console.WriteLine("Loodan,et käid koolis ja õpi hästi");
            }
            else if (age > 18 && age <= 75)
            {
                Console.WriteLine("Oled vist tööl");
            }
            else if (age > 75 && age <= 130)
            {
                Console.WriteLine("Loodan,et puhkad kuskil soojal maal");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.ReadKey();
        }
    }
}
