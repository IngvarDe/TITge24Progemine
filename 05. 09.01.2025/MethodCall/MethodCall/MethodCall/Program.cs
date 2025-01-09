namespace MethodCall
{
    internal class Program
    {
        static void Jalgratas()
        {
            Console.WriteLine("N[[d oled jalgratta meetodis");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main meetodi algus");

            //kutsume esile Jalgratta meetodi
            Jalgratas();

            Console.WriteLine("See on main meetodi lõpp");
        }

        //teha uus meetod nimega Jalgratas
    }
}
