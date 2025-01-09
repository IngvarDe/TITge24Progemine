namespace MethodCallTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //siin kasutada if ja else
            //m]lemas valikus peab v'lja kutsuma meetodi
            //teemaks paaris ja paaritud arvud
            string nr = Console.ReadLine();
            int number = Convert.ToInt32(nr);

            if (int.IsEvenInteger(number))
            {
                EvenNumbers(number);
            }
            else
            {
                OddNumbers(number);
            }
        }

        static void OddNumbers(int nr)
        {
            Console.WriteLine("Tegemist on paaritu arvuga " + nr);
        }
        static void EvenNumbers(int nr)
        {
            Console.WriteLine("Tegemist on paaris arvuga " + nr);

        }
    }
}
