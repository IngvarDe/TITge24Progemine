namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu veeretamine");
            var values = new List<object>();

            for (int ctr = 0; ctr <= 5; ctr++)
            {
                if (ctr == 2)
                {
                    values.Add(DiceLibary.Roll2());
                }
                else if (ctr == 4)
                {
                    values.Add(DiceLibary.Pass());
                }
                else
                {
                    values.Add(DiceLibary.Roll());
                }
            }
            Console.WriteLine($"The sum of {values.Count} die is" +
                $" {DiceLibary.DiceSum(values)}!");
        }
    }

    public static class DiceLibary
    {
        static Random rnd = new Random();

        //tuleb teha meetod, mis annab meile randomina numbreid 1-st kuni 6-ni
        //meetodi nimi on Roll
        //need numbrid tagastatkse
        public static int Roll()
        {
            return rnd.Next(1, 7);
        }

        //tuleb teha meetod, kus kutsutakse kaks korda esile
        //Roll meetod
        //see meetod tuleb panna list
        public static List<object> Roll2()
        {
            var rolls = new List<object>();
            rolls.Add(Roll());
            rolls.Add(Roll());
            return rolls;
        }

        //meetod, mis kalkuleerib summad kokku
        //kasutame switchi
        public static int DiceSum(IEnumerable<object> values)
        {
            var sum = 0;

            //toimub foreach
            //ja omakorda selle sees on switch
            foreach (var item in values)
            {
                switch (item)
                {
                    //0, siis toimub break
                    case 0:
                        break;
                    //[ks v''rtus, siis teeb += ja case on int val
                    case int val:
                        sum += val;
                        break;

                    //mitte-t[hi collection
                    case IEnumerable<object> sublist when sublist.Any():
                        sum += DiceSum(sublist);
                        break;

                    //t[hi colletcion
                    case IEnumerable<object> sublist:
                        break;

                    //null viide
                    case null:
                        break;

                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }

            return sum;
        }

        public static object Pass()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return null;
            }
            else
            {
                return new List<object>();
            }
        }
    }
}
