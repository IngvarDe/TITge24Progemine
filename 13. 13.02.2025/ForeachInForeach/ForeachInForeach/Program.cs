namespace ForeachInForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach nesting!");

            var words = new List<List<string>>
            {
                new List<string> { "tea", "coffee", "juice", "smoothie" },
                new List<string> { "cup", "plate", "knife", "spoon" },
                new List<string> { "rain", "snow", "hailstorm", "sunny" }
            };

            foreach (var word in words) 
            {
                foreach (var item in word)
                {
                    Console.WriteLine(item);
                }
            };
        }
    }
}
