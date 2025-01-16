namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //peab sisestama numbrid 1 või 2
            //kasutada switchi, mis tuvastab numbri
            //try catchi sisse panete switchi
            //Kui sisestasid nr 3-e, siis catch ütleb, et liiga suur number

            try
            {
                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Sisestasid nr 1");
                        break;

                    case 2:
                        Console.WriteLine("Sisestasid nr 2");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ei sisestanud numbri formaati");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR.Sisestatud number on liiga suur");
            }
        }
    }
}
