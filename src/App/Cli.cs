public class Cli
{
    public static void Greeting()
    {
    Console.Write("May I have your name? ");
    var name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}!");
    }
}