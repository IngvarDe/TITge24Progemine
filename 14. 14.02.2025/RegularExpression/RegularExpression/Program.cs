using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string word = "#YD5C5C";
            Console.WriteLine("Hex code: " + word);
            Console.WriteLine("Is Regex: " + RegExTest(word));
        }
        //tee regex, mis on falsetulemusega
        //põhjenda ära, et miks on false

        public static bool RegExTest(string word)
        {
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}
