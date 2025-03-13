namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List!");

            SortedList<int, string> numbrid = new SortedList<int, string>()
            {
                {3, "Three" },
                {5, "Five" },
                {1, "One" },
            };

            Console.WriteLine("Algne key value");
            //sorteerib numbriväärtuste järgi ära
            foreach (KeyValuePair<int, string> kvp in numbrid)
            {
                Console.WriteLine("Key: {0}, value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("---------------------------------------------");
            //tehke sortedlist, kus linnad ja kasutate kahte stringi
            SortedList<string, string> words = new SortedList<string, string>()
            {
                {"Tallinn", "EST"},
                {"London", "UK"},
                {"Madrid", "ESP"},
            };

            foreach (KeyValuePair<string, string> kvp in words)
            {
                Console.WriteLine("Key: {0}, value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("lisame kaks linna juurde");
            Console.WriteLine("kui lisame kaks linna juurde, siis paneb need ka järjestusse");
            //aga SortedListi ei tohi kasutada
            words.Add("New York", "USA");
            words.Add("Brazil", "BRA");

            foreach (KeyValuePair<string, string> kvp in words)
            {
                Console.WriteLine("Key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
