public class Cli
{
    public static string Greeting()
    {
        Console.Write("May I have your name? ");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");

        return name;
    }
}
