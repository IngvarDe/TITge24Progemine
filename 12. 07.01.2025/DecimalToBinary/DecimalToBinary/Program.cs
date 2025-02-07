namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");
            //teha vooskeem
            int n1;
            string binaryNumber = "";

            Console.WriteLine("Input First Number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            while (n1 > 0)
            {
                int reminder = n1 % 2;
                binaryNumber = reminder + binaryNumber;
                n1 /= 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}
