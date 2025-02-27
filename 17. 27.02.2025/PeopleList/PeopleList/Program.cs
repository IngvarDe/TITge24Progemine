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
            Console.WriteLine("4. GroupBy LINQ");
            Console.WriteLine("5. ToLookUp LINQ");
            Console.WriteLine("6. Join LINQ");
            Console.WriteLine("7. GroupJoin LINQ");
            Console.WriteLine("8. Avarage LINQ");
            Console.WriteLine("9. Count LINQ");

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

                case 4:
                    GroupByLINQ();
                    break;

                case 5:
                    ToLookUpLINQ();
                    break;

                case 6:
                    JoinLINQ();
                    break;

                case 7:
                    GroupJoinLINQ();
                    break;

                case 8:
                    AvarageLINQ();
                    break;

                case 9:
                    CountLINQ();
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

        public static void GroupByLINQ()
        {
            var result = PeopleList.peoples
                .GroupBy(x => x.Age);

            foreach (var age in result)
            {
                Console.WriteLine("Age group " + age.Key);

                foreach (var people in age)
                {
                    Console.WriteLine("People name: " + people.Name);
                }
            }
        }

        static void ToLookUpLINQ()
        {
            var result = PeopleList.peoples
                .ToLookup(x => x.Age);

            foreach (var age in result)
            {
                Console.WriteLine("Age group " + age.Key);

                foreach (var people in age)
                {
                    Console.WriteLine("People name: " + people.Name);
                }
            }
        }

        static void JoinLINQ()
        {
            //mõlema tabeli muutujad ühendati ära, et kuvada infot
            var innerJoin = PeopleList.peoples
                .Join
                (
                    GenderList.genderList,
                    humans => humans.GenderId,
                    gender => gender.Id,
                    (humans, gender) => new 
                    {
                        Name = humans.Name,
                        GenderName = gender.GenderName,
                    }
                );

            foreach (var item in innerJoin)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.GenderName);
            }
        }

        static void GroupJoinLINQ()
        {
            var groupJoin = GenderList.genderList
                .GroupJoin
                (
                    PeopleList.peoples,
                    p => p.Id,
                    g => g.GenderId,
                    (p, peopleGroup) => new
                    {
                        Name = peopleGroup,
                        GenderFullName = p.GenderName,
                    }
                );

            foreach(var item in groupJoin)
            {
                Console.WriteLine(item.GenderFullName);

                foreach (var name in item.Name)
                {
                    Console.WriteLine(name.Name);
                }
            }
        }

        static void AvarageLINQ()
        {
            var avarageResult = PeopleList.peoples
                .Average(x => x.Age);

            Console.WriteLine(avarageResult);
        }

        static void CountLINQ()
        {
            var totalPersons = PeopleList.peoples.Count();

            Console.WriteLine(totalPersons);

            var adultPerson = PeopleList.peoples.Count(x => x.Age >= 18);

            Console.WriteLine("Täisealisi inimesi on: " + adultPerson);
        }
    }
}
