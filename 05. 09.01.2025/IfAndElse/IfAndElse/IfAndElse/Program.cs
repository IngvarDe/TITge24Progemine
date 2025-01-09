namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ainult number");

            string age = Console.ReadLine();
            int ageConverted = int.Parse(age);

            if (ageConverted >= 0 && ageConverted <= 18)
            {
                Console.WriteLine("Oled alaealine");
            }
            else if (ageConverted >= 18 && ageConverted < 65)
            {
                Console.WriteLine("Oled täisealine");
            }
            else
            {
                Console.WriteLine("Oled pensionäär");
            } 
            //if ja else rakendus tuleb teha
            //kontrollib sinu vanust
            //1. kui oled alla 18, siis konsool annab vastuseks,
            //et oled alaealine

            //2. Kui oled 19 kuni 65 aastat vana, siis
            // konsool vastab, et oled täisealine

            //3. Kui oled üle 65 a vana, siis pensionäär
        }
    }
}
