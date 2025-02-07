namespace NumberLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach and for loop!");

            int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            foreach (int i in oddArray)
            {
                Console.WriteLine(i);

                if (i == 13)
                {
                    break;
                }
                //kuni 13 numbrini ja siis lõpetab loopimise ära
            }

            for (int i = 1; i < (99 + 1); i++)
            {
                if (i <= 14)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
        }
    }
}
