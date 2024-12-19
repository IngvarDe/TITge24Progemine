namespace RingCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3.
            //Leia ja väljasta ekraanile ruudu pindala ja ruudu ümbermõõt.
            //Leia ja väljasta ekraanile ringi pindala ja ringi ümbermõõt.

            int roundRadius = 3;
            int squareSide = 6;

            Console.WriteLine("Ruudu pindala " + squareSide * squareSide);
            Console.WriteLine("Ruudu ümbermõõt " + 4 * squareSide);

            Console.WriteLine("Ringi pindala " + Math.PI * (roundRadius * roundRadius));
            Console.WriteLine("Ringi ümbermõõt " + 2 * Math.PI * roundRadius);


        }
    }
}
