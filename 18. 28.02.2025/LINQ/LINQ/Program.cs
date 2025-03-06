namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik numbriga");

            Console.WriteLine("1. Sum LINQ");
            Console.WriteLine("2. Max LINQ");
            Console.WriteLine("3. Aggregate LINQ");
            Console.WriteLine("4. Min LINQ");
            Console.WriteLine("5. Skip LINQ");
            Console.WriteLine("6. SkipWhile LINQ");
            Console.WriteLine("7. Take LINQ");
            Console.WriteLine("8. TakeWhile LINQ");
            Console.WriteLine("9. FirstOrDefault LINQ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SumLINQ();
                    break;

                case "2":
                    MaxLINQ();
                    break;

                case "3":
                    AggregateLINQ();
                    break;

                case "4":
                    MinLINQ();
                    break;

                case "5":
                    Skip();
                    break;

                case "6":
                    SkipWhile();
                    break;

                case "7":
                    Take();
                    break;

                case "8":
                    TakeWhile();
                    break;

                case "9":
                    FirstOrDefault();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        public static void SumLINQ()
        {
            var sumAge = PeopleList.people
                .Sum(x => x.Age);

            Console.WriteLine(sumAge);

            Console.WriteLine("Täisealiste isikute koondarv");

            var sumAdults = PeopleList.people.Sum(x =>
                {
                    if (x.Age >= 18)
                    {
                        return x.Age;
                        //return 1;
                    }
                    else
                    {
                        return 0;
                    }
                });

            Console.WriteLine("Täiskasvanute isikute arv on " + sumAdults);
        }

        public static void MaxLINQ()
        {
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);

            Console.WriteLine("Kõige vanem inimene on " + oldestPerson + " aastane.");
        }

        public static void AggregateLINQ()
        {
            string commaSeparatedPersonsNames = PeopleList.people
                .Aggregate<People, string>(
                "People names: ",
                (str, y) => str += y.Name + ", "
                );

            Console.WriteLine(commaSeparatedPersonsNames);
        }

        public static void MinLINQ()
        {
            var oldestPerson = PeopleList.people
                .Min(x => x.Age);

            Console.WriteLine("Kõige noorem inimene on " + oldestPerson + " aastane.");
        }

        public static void Skip()
        {
            Console.WriteLine("----------Skip---------");
            var skip = PeopleList.people.Skip(3);

            foreach (var x in skip)
            {
                Console.WriteLine(x.Id);
            }
        }

        public static void SkipWhile()
        {
            Console.WriteLine("----------SkipWhile---------");
            var skip = PeopleList.people.SkipWhile(x => x.Age > 18);

            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + " " + x.Name);
            }
        }

        public static void Take()
        {
            Console.WriteLine("----------Take---------");
            var skip = PeopleList.people.Skip(3);

            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + " " + x.Name);
            }
        }

        public static void TakeWhile()
        {
            Console.WriteLine("----------TakeWhile---------");
            var skip = PeopleList.people.TakeWhile(x => x.Age > 18);

            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + " " + x.Name);
            }
        }

        public static void FirstOrDefault()
        {
            string firstLongName = PeopleList.people
                .FirstOrDefault(person => person.Name.Length > 5)?.Name;

            Console.WriteLine("The first long name is '{0}'", firstLongName);
        }

        //Teha Skip, SkipWhile, Take, TakeWhile ja FirstOrDefault LINQ.
        //Iga selle jaoks tuleb teha eraldi meetod.
        //Meetodi sisse kirjuta kommentaar, et mida antud LINQ teeb.
        //Iga meetodi peab saama läbi switchi esile kutsuda
        //SkipWhile meetodist tee vooskeem.
    }
}
