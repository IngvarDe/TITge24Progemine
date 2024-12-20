namespace ForLoopKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta korduste arv");
            /*Ülesanne 3
            Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            kill-koll kill-koll killadi-koll kill-koll kill-koll 
            killadi-koll kill-koll kill-koll killadi-koll*/
            //for loop for loopi sees

            int arv = Int16.Parse(Console.ReadLine());

            for (int i = 1; i <= arv; i++)
            {
                Console.WriteLine("See rida on nr {0}", i);
                string a = "kill-koll";
                string b = "killadi-koll";

                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine(a);
                }

                for (int k = 1; k <= 1; k++)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
