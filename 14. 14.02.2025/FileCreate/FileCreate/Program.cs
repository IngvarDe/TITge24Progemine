namespace FileCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"C:/Users/Ingvar/Desktop/WriteToFile.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
    }
}
