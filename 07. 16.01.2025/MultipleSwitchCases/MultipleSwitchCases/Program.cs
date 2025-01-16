namespace MultipleSwitchCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases");

            string topic, category;

            string names = Console.ReadLine();

            switch (names)
            {
                case "Intro to C#":
                case "Variables":
                case "Data types":

                    category = "Basic";
                    break;

                case "Loops":
                case "If statements":
                case "Jump statements":

                    category = "Control Flow";
                    break;

                case "Class & Objects":
                case "Inheritance":
                case "Constructors":

                    category = "OOP-s concept";
                    break;

                default:
                    category = "UNKNOWN";
                    break;
            }

            Console.WriteLine("Category is " + category);
        }
    }
}
