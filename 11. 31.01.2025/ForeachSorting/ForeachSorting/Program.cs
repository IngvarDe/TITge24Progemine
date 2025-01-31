namespace ForeachSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] genders = { "m", "f", "m", "m", "m", "f", "f", "m", "m", "f" };
            int female = 0, male = 0;

            foreach (var gender in genders)
            {
                //if (gender == "f")
                //{
                //    female++;
                //}
                //if (gender == "m")
                //{
                //    male++;
                //}

                var result = gender == "f" ? female++ : male++;
            }

            Console.WriteLine("Number of female: {0}", female);
            Console.WriteLine("Number of male: {0}", male);
        }
    }
}
