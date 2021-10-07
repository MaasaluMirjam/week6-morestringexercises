using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime pikkust kokku
            //Lenght omadust kasutamata

            Console.WriteLine("Sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();
            string fullname = $"{firstname}{lastname}";

            int charCounter = 0;
            foreach (char c in fullname)
            {
                charCounter++;
            }
            Console.WriteLine($"Nimes {fullname} on {charCounter} tähte pikk.");
        }
    }
}
