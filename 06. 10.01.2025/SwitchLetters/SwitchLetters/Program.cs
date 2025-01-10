namespace SwitchLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vokaal (a, e, i) ja vajuta enter");

            string ch = Console.ReadLine();

            switch (ch.ToLower())
                //kui kasutad ToLower, siis ei ole vaja teist case
            {
                case "a":
                //case "A":
                    Console.WriteLine("Sisestasid vokaali: " + ch);
                    break;

                case "e":
                //case "E":
                    Console.WriteLine("Sisestasid vokaali: " + ch);
                    break;

                case "i":
                //case "I":
                    Console.WriteLine("Sisestasid vokaali: " + ch);
                    break;

                //default:
                    Console.WriteLine("Ei ole vokaal");
                    break;
            }
        }
    }
}
