namespace StringLengthCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] animalName = { "Koer", "Kass", "Jänes", "Sipelgasiil", "Lendorav" };
            /*
            >>>>>>>>>>
            Koer, kass, jänes, sipelgasiil ja lendorav hakkasid vaidlema, 
            kellel on kõige pikem nimetus. Koosta programm, kus on antud loomanimede järjend.
            Loo funktsioon, mis saab argumendina ette looma nime ning tagastab (mitte ei trüki!) 
            selle pikkuse. Lase programmil kutsuda funktsiooni välja
            iga loomanimede järjendi elemendiga ning trükib ekraanile nime pikkuse. 
            Pärast pikkuste kontrollimist peab programm väljastama kõige pikema loomanime
            (võrdsete pikkuste puhul võib esitada vaid ühe pikimatest).'
            */
            int longerName = animalName[0].Length;
            string longerNameString = animalName[0];

            for (int i = 0; i < animalName.Length; i++)
            {
                if (longerName < animalName[i].Length)
                {
                    longerName = animalName[i].Length;
                    longerNameString = animalName[i];
                }

                int animalLength = AnimalNameLength(animalName[i]);
                Console.WriteLine(animalName[i] + " = ");
                Console.WriteLine(animalLength);
            }

            Console.WriteLine("Pikim nimi oli {0} ja mille nime pikkus on: {1}", longerNameString, longerName);
        }

        static int AnimalNameLength(string animalName)
        {
            return animalName.Length;
        }
    }
}
