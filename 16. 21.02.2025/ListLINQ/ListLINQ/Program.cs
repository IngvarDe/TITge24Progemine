namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ");

            IList<Person> person = new List<Person>()
            {
                new() {Id = 1, Name = "Juku", Age = 10},
                new() {Id = 2, Name = "Juhan", Age = 11},
                new() {Id = 3, Name = "Maali", Age = 9},
                new() {Id = 4, Name = "Aksel", Age = 10},
            };

            var persons = from s in person
                          select new
                          {
                              Id = s.Id, 
                              Name = s.Name, 
                              Age = s.Age,
                          };

            //kasutada foreachi ja peab n'gema 4 rida andmeid
            foreach (var item in persons)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("LINQ select e teine variant");

            var result = person
                .Where(x => x.Id == 1 || x.Age == 9)
                //.OrderBy(x => x.Name) //järjestab isikud nime järgi ära
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                });

            foreach (var item in result)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Kasutame GroupBy-d sorteerimiseks");

            //sorteerite GroupBy j'rgi:
            var groupBy = person
                .GroupBy(x => x.Age);

            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }
        }
    }
}
