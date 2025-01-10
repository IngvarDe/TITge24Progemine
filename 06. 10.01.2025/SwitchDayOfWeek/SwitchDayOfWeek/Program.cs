namespace SwitchDayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //kasutada switchi ja näitab tänast päeva

            switch (DateTime.Now.DayOfWeek)
            {   
                case DayOfWeek.Sunday:
                    Console.WriteLine("Täna on pühapäev");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Täna on esmaspäev");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Täna on teisipäev");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Täna on kolmapäev");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Täna on neljapäev");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Täna on reede");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Täna on laupäev");
                    break;
                default:
                    Console.WriteLine("mingi imelik päev");
                    break;
            }
        }
    }
}
