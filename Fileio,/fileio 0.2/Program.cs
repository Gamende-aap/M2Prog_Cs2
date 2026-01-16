namespace fileio_0._2;

using System;

using System.IO;
 
class Program

{

    static void Main()

    {

        // Bestandsnaam waar we de tekst bewaren

        string saveFile = "welkomState.txt";
 
        // 1. Lezen van de vorige opgeslagen tekst (als die bestaat)

        if (File.Exists(saveFile))

        {

            string oudeTekst = File.ReadAllText(saveFile);

            Console.WriteLine("Vorige tekst: " + oudeTekst);

        }

        else

        {

            Console.WriteLine("Geen bestaande tekst gevonden.");

        }
 
        // 2. Nieuwe tekst vragen

        Console.WriteLine("Typ een nieuwe tekst:");

        string nieuweTekst = Console.ReadLine();
 
        // 3. Opslaan naar het bestand

        File.WriteAllText(saveFile, nieuweTekst);
 
        Console.WriteLine("Je tekst is opgeslagen!");

    }

}

 