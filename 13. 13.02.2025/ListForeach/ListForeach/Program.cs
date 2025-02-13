namespace ListForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autoosade list");

            //teha vooskeem

            var parts = new List<CarPart>()
            {
                new() {Id = 1, PartName = "crank arm"},
                new() {Id = 2, PartName = "chain ring"},
                new() {Id = 3, PartName = "regular seat"},
                new() {Id = 4, PartName = "banana seat"},
                new() {Id = 5, PartName = "cassette"},
                new() {Id = 6, PartName = "shift lever"}
            };

            foreach (var part in parts)
            {
                Console.WriteLine(part.Id + " " + part.PartName);
            }
        }
    }

    public class CarPart
    {
        public int Id { get; set; }
        public string PartName { get; set; }
    }
}
