namespace IfElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else nestimine");
            Console.WriteLine("Sisesta kujundi nimetus:");
            Console.WriteLine("nurgelised või ringjad");

            // teha enda valikul [ks if ja else nestimine
            //teema m]
            string shape = Console.ReadLine();

            if (shape == "nurgelised")
            {
                Console.WriteLine("Sisesta nelinurk või nurgeline");
                string corner = Console.ReadLine();
                if(corner == "nelinurk")
                {
                    Console.WriteLine("See on nelinurk");
                }
                else
                {
                    Console.WriteLine("See on äkki mingi muu nurgeline");
                }
            }
            else
            {
                Console.WriteLine("Siin on mingid ringjad kujundid");
            }
        }
    }
}
