namespace App.Games;

public class Cli
{
    public static string Greeting()
    {
        Console.Write("May I have your name? ");
        string? name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            name = "Guest";
        }
        Console.WriteLine($"Hello, {name}!");
        return name;
    }
}
