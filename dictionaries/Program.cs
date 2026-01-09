namespace dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(879987, "Jansen");
        personeelOpNummer.Add(778654, "Pietersen");

        string jim = personeelOpNummer[879987];
        Console.WriteLine(jim);

        personeelOpNummer.Add(123456, "Tim");
        string tim = personeelOpNummer[123456];
        Console.WriteLine(tim);

        Console.WriteLine(jim);
        Console.WriteLine(tim);

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            string naam = item.Value;
            Console.WriteLine(naam);

            int nummer = item.Key;
            Console.WriteLine(nummer);

            Console.WriteLine($"{nummer}: {naam}");
        }

        foreach (int key in personeelOpNummer.Keys)
        {
            Console.WriteLine(key);
        }

        foreach (string value in personeelOpNummer.Values)
        {
            Console.WriteLine(value);
        }
    }
}
