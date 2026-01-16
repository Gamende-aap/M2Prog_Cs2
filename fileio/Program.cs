namespace fileio;

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Run();
        string[] lines = File.ReadAllLines("quiz.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        string[] lines2 = File.ReadAllLines("nos.txt");
        foreach (string line in lines2)
        {
            Console.WriteLine(line);
        }
    }

    static void Run()
    {
        Console.WriteLine("Project is running!");
        Console.WriteLine(Environment.CurrentDirectory);
    }
}
