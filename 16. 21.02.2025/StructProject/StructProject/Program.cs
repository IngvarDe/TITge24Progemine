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

            Name = name;
            Age = age;
        }
    }
}
