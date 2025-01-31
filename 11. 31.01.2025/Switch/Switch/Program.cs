namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
            Ülesanne 6
            >>>>>>>>>>
            Eurosendid on väärtuses 1, 2, 5, 10, 20 ja 50. Koostage funktsioon,
            millele antakse argumendina rahasumma (sentides) ja mis trükib välja, kui palju milliseid
            münte peaks selles vääringus andma, et müntide arv oleks väikseim. Näiteks 37 sendi puhul
            1 20-sendine, 1 10-sendine, 1 5-sendine ja 1 2-sendine. Koostage järjend, mille elementideks
            on teisendatavad rahasummad. Koostage programm, mis võtab järjendist elemente ja kutsub
            igaühe korral neist välja ülaltoodud funktsiooni. Probleeme tekitab kindlasti korrektse
            lause koostamine (mida teha, kui mingis vääringus münte ei vajata? mida teha ainsuse ja mitmusega?).
            Püüdke leida parim võimalik lahendus.
            */

            const int yks = 1, kaks = 2, viis = 5, kymme = 10, kakskymmend = 20, viiskymmend = 50;

            Console.WriteLine("Sisesta jagatava sentide vääring: ");
            int middleSum = int.Parse(Console.ReadLine());

            Console.WriteLine("Vajuta nr 1 ja enter");
            int ammountCent = 0;
            string sum = Console.ReadLine();

            switch (sum)
            {
                case "1":
                    ammountCent = middleSum / viiskymmend;
                    Console.WriteLine("50-sendised: " + ammountCent + " tk");

                    middleSum = middleSum - ammountCent * viiskymmend;
                    ammountCent = middleSum / kakskymmend;
                    Console.WriteLine("20-sendised: " + ammountCent + " tk");

                    middleSum = middleSum - ammountCent * kakskymmend;
                    ammountCent = middleSum / kymme;
                    Console.WriteLine("10-sendised: " + ammountCent + " tk");

                    middleSum = middleSum - ammountCent * kymme;
                    ammountCent = middleSum / viis;
                    Console.WriteLine("5-sendised: " + ammountCent + " tk");

                    middleSum = middleSum - ammountCent * viis;
                    ammountCent = middleSum / kaks;
                    Console.WriteLine("2-sendised: " + ammountCent + " tk");

                    middleSum = middleSum - ammountCent * kaks;
                    ammountCent = middleSum / yks;
                    Console.WriteLine("1-sendised: " + ammountCent + " tk");

                    break;
                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud");
                    break;
            }
        }
    }
}
