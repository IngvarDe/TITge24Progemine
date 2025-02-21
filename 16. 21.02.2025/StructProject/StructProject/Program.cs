using System.ComponentModel;

namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");

            Coordinate point = new Coordinate();
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Console.WriteLine("------------------");
            //kuidas kutsuda IntAndString v'lja???
            Console.WriteLine("Sisesta nimi ja vajuta enter:");
            string someName = Console.ReadLine();

            Console.WriteLine("Sisesta vanus ja vajuta enter:");
            int someAge = Int32.Parse(Console.ReadLine());

            IntAndString intAndString = new(intAndString.Name = someName, intAndString.Age = someAge);
            Console.WriteLine(intAndString.Name);
            Console.WriteLine(intAndString.Age);
        }
    }

    struct Coordinate
    {
        public int X;
        public int Y;

        //kontruktor teha
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    struct IntAndString
    {
        public string Name;
        public int Age;

        public IntAndString(string name, int age)
        {

            this.Name = name;
            this.Age = age;
        }
    }
}
