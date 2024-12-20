namespace AroundEarth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vaja arvutada, mitu kahe eurost münti läheb ümber maa
            //maa ümbermõõt tuleb välja arvutada raadiuse abil

            Console.WriteLine("Hello, World!");

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000;
            double aroundEarth = 2 * Math.PI * earthRadius;

            Console.WriteLine("Maa ümbermõõt: " + aroundEarth);

            //nüüd alles müntide arv välja arvutada
            double howManyCoins = aroundEarth / coinDiameter;

            Console.WriteLine("Ümber maa mahub nii " +
                "palju kahe euroseid " + howManyCoins);
        }
    }
}
