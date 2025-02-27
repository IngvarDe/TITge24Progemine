namespace PeopleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            Console.WriteLine("Tee valik numbrina");
            Console.WriteLine("1. ThenBy LINQ");
            Console.WriteLine("2. ThenByDescending LINQ");
            Console.WriteLine("3. Select LINQ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThenByLINQ();
                    break;

                case 2:
                    ThenByDescendingLINQ();
                    break;

                case 3:
                    SelectLINQ();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        public static void ThenByLINQ()
        {
            //mida teeb thenby
            //sorteerib t'hestiku j'rjekorras
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            Console.WriteLine("ThenBy järgi");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        public static void ThenByDescendingLINQ()
        {
            //mida teeb thenby
            //sorteerib t'hestiku j'rjekorras
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Age);

            Console.WriteLine("ThenByDescending järgi");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        public static void SelectLINQ()
        {
            var selectResult = PeopleList.peoples
                .Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age
                });

            Console.WriteLine("Select järgi");
            foreach (var people in selectResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
    }
}
