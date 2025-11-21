namespace Functions;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run(); //program heet het programma

    }
    internal void run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        Console.WriteLine("Dit is het einde van mijn programma");
    }

    internal void Vraag1()
    {
        Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    
    internal void Vraag2()
    {
        Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
        string antwoord2 = Console.ReadLine();
        Console.WriteLine(antwoord2);
    }
    
    internal void Vraag3()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord3 = Console.ReadLine();
        Console.WriteLine(antwoord3);
    }
    
    internal void Vraag4()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord4 = Console.ReadLine();
        Console.WriteLine(antwoord4);
    }
    
    internal void Vraag5()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?");
        string antwoord5 = Console.ReadLine();
        Console.WriteLine(antwoord5);
    }
}
