namespace Functions;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run(); //program heet het programma

    }
    
    internal void AskRandomQuestion()
    {
        string vraag = Getrandomvraag();
        Console.WriteLine(vraag);
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    
        string[] vragen = new string[]
        {
            "What secret conspiracy would you like to actually start letting other people know?",
            "If you can still remember, what are your funniest childhood memories?",
            "What would you do if you won a million dollars?",
            "What is the worst game you played but that you liked anyway?",
            "Why do round pizzas come in square boxes?",
            "Has someone caught you dancing in front of the mirror?",
            "What would you call a male ladybug?"
        };
    
    internal string Getvraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }

    internal string Getrandomvraag()
    {
        Random random = new Random();
        int index = random.Next(vragen.Length);
        return vragen[index];
    }


    internal void run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();

        
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

    internal void Vraag6()
    {
        Console.WriteLine("Has someone caught you dancing in front of the mirror?");
        string antwoord6 = Console.ReadLine();
        Console.WriteLine(antwoord6);
    }

    internal string Vraag7()
    {
        Console.WriteLine("What would you call a male ladybug?");
        string antwoord7 = Console.ReadLine();
        return antwoord7;
    }

    
}
