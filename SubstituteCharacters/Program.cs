using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi ja perekonnanimi
            //programm asendab kõik 'a' tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis

            Console.WriteLine("Sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();
            string fullname = $"{firstname} {lastname}";

            fullname = fullname.Replace('a', '*');

            Console.WriteLine(fullname);
        }
    }
}
