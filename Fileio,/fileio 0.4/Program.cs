namespace fileio_0._4;

using System;
using System.IO;
using System.Text.Json;
 
class FavoriteGame
{
    public string Name { get; set; }
    public string Platform { get; set; }
}
 
class Program
{
    static void Main()
    {
        FavoriteGame[] favoriteGames = new FavoriteGame[]
        {
            new FavoriteGame { Name = "The Witcher 3", Platform = "PC" },
            new FavoriteGame { Name = "God of War", Platform = "PS5" },
            new FavoriteGame { Name = "Halo Infinite", Platform = "Xbox" }
        };
 
        string json = JsonSerializer.Serialize<FavoriteGame[]>(favoriteGames);
        string bestandspad = Path.Combine("bin", "Debug", "net9.0", "games.json");
        File.WriteAllText(bestandspad, json);
 
        Console.WriteLine("Games opgeslagen in " + bestandspad);
 
        // Inladen en tonen
        string jsonFromFile = File.ReadAllText(bestandspad);
        FavoriteGame[] loadedGames = JsonSerializer.Deserialize<FavoriteGame[]>(jsonFromFile);
 
        Console.WriteLine("\nIngeladen games:");
        foreach (var game in loadedGames)
        {
            Console.WriteLine($"Naam: {game.Name}, Platform: {game.Platform}");
        }
    }
}