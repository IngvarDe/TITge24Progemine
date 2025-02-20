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

            var weekDay = (Weekdays)1;
            Console.WriteLine(weekDay);

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
    }
}
