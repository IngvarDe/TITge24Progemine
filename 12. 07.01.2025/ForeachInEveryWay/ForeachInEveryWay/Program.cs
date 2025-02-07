namespace ForeachInEveryWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach harjutused");
            Console.WriteLine("1. List, kus on foreach");
            Console.WriteLine("2. List, kus on for");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                ForeachWithList();
            }
            else if (choice == 2)
            {
                ForWithList();
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            //1. Tuleb teha rakendus, kus on list
            //ja seal sees on 5 string väärtust.
            //Need omakorda tuleb kuvada konsoolis
            //ning kasutada foreachi ja fori.
            //See tuleb läbi meetodi esile kutsuda ja
            //sina saad valida, et kumba meetodi kasutada
        }

        static void ForeachWithList()
        {
            var names = new List<string>() { "John", "Tom", "Anu", "Villu", "James"};

            foreach (var name in names)
            {
                if (name == "Anu")
                {
                    break;
                }
                Console.WriteLine(name);
            }
        }

        static void ForWithList()
        {
            var names = new List<string>() { "John", "Tom", "Anu", "Villu", "James" };

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
