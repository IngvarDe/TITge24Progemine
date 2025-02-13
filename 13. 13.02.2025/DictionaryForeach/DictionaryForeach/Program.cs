namespace DictionaryForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary ja foreach");

            var domains = new Dictionary<string, string>()
            {
                { "est", "Estonia" },
                { "lat", "Latvia" },
                { "fin", "Finland" },
                { "swe", "Sweden" }
            };

            int i = 0;
            foreach (var pair in domains)
            {
                i++;
                Console.WriteLine($"{pair.Key} - {pair.Value} - {i}");
            }

            //peate kasutama foreachi
        }
    }
}
