namespace AgeTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tingimuslaused IF...ELSE";
            Console.WriteLine("\tTingimuslaused IF...ELSE\n\n");
            Console.WriteLine("\tMis pilet sulle sobib\n\n");
            Console.WriteLine("Sisesta inimese vanus (täisarv) -");
            //alla 6 aastased on tasuta, 7 kuni 18 on õpilaspiletiga ja 
            //ülejäänud on tasulised
            int age = int.Parse(Console.ReadLine());

            if (age > 0)
            {
                if (age <= 6)
                {
                    Console.WriteLine("Oled tasuta s]itja");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("Oled õpilane ja saad poole hinnaga");
                }
                else
                {
                    Console.WriteLine("Köhi raha välja, maksa");
                }
            }
            else
            {
                Console.WriteLine("Vanus nr ei vasta nõuetele");
            }
        }
    }
}
