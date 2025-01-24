namespace ForUshort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // hakkab itereerima nii kaua kuni ushort 
            // andmetüübist saadakse kätte maksimaalne arv e 63 tuhat
            // peale seda alustab uuesti
            // lõputu itereerimine tuleneb tingimuste puudumisest
            // kasutada for loopi
            ushort i = 0;
            for (;;)
            {
                Console.WriteLine("i väärtus on: {0}", i);
                i++;
            }
        }
    }
}
