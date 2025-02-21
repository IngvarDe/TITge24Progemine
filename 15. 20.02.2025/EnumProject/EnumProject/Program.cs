namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum!");

            //kutsu välja enumist esmaspäev
            Console.WriteLine(Weekdays.Monday);

            int day = (int)Weekdays.Friday;
            Console.WriteLine(day);

            var weekDay = (Weekdays)4;
            Console.WriteLine(weekDay);

            int color = (int)Colors.Yellow;
            Console.WriteLine(color);
            //lubab ainult neid väärtuseid sisestada,
            //mis on enum classis defineeritud
        }

        enum Weekdays
        {
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday, 
            Saturday, 
            Sunday
        }

        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1
        }
    }
}
