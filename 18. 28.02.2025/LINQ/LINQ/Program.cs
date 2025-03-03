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
            //
            var oldestPerson = PeopleList.people
                .Min(x => x.Age);

            Console.WriteLine("Kõige noorem inimene on " + oldestPerson + " aastane.");
        }

        //Teha Skip, SkipWhile, Take, TakeWhile ja FirstOrDefault LINQ.
        //Iga selle jaoks tuleb teha eraldi meetod.
        //Meetodi sisse kirjuta kommentaar, et mida antud LINQ teeb.
        //Iga meetodi peab saama läbi switchi esile kutsuda
        //SkipWhile meetodist tee vooskeem.
    }
}
