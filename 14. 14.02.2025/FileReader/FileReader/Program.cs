namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FileWordReading();
        }

        static void FileWordReading()
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Ingvar/Desktop/luuletus.txt"))
                {
                    int cnt = 0; //rea muutuja
                    while (sr.EndOfStream == false)
                    {
                        ++cnt; //rea nr suurendamine 1 ühiku võrra
                        line = sr.ReadLine(); //teksti lugemine txt failist
                        int length = line.Length; //sõna lugemine, kui sõne pikkusena
                        Console.WriteLine(cnt + " " + line + " " + length);
                    }
                    sr.Close(); //faili lugemise l]petamine
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Faili ei saa lugeda");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
