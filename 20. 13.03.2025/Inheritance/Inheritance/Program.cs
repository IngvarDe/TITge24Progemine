namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            int firstNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta teine number");
            int secondNr = Convert.ToInt32(Console.ReadLine());
            //kutsud esile Rectangle classi ja suunad kaks v''rtust sellesse klassi
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(firstNr);
            rectangle.SetHeight(secondNr);

            Console.WriteLine("Pindala on: {0}", rectangle.GetArea());
        }
    }

    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }

    class Rectangle : Shape
    {
        public int GetArea()
        {
            return (width * height);
        }
    }
}
