namespace RandomAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           /*
           Ülesanne:
           >>>>>>>>>>
           Loo funktsioon, mis saab argumendina
           ette täisarvu ja trükib ekraanile sama suure
           arvu tärne. Koosta programm, mis
           kutsub seda funktsiooni välja 30 korda
           juhuslike positiivsete täisarvudega,
           mis on väiksemad kui 20.
           Näiteks:
           ************
           *********
           **********************
           *******
           */
           int stringRowMin = 0;
           int stringRowMax = 10;

            int[] randomAsterisk = new int[stringRowMax];

            Random asterisk = new Random();
            for (int i = stringRowMin; i < randomAsterisk.Length; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*",
                    asterisk.Next(1,20))));
            }
        }
    }
}
