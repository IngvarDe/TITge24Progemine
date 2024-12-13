namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Else if-i sisse panna if ja else võrdlus");
            //Küsitakse numbrit ja toimub if ja else loogika
            int number = int.Parse(Console.ReadLine());

            if (number == 12)
            {
                Console.WriteLine("Number v]rdub 12");
            }
            else if (number >= 13 && number <= 25)
            {
                //nestimine
                if (number == 17)
                {
                    Console.WriteLine("Number on 17");
                }
                else
                {
                    Console.WriteLine("Number on 13 kuni 16 ja 18 kuni 25");
                }
            }
            else
            {
                Console.WriteLine("Mingid kahtlased v''rtused");
            }
        }
    }
}
