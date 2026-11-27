// See https://aka.ms/new-console-template for more information
using App.Games;

Console.WriteLine("Welcome to the Brain Games!");

Console.WriteLine("Please enter the game number and press Enter.");
Console.WriteLine("1 - Greet");
Console.WriteLine("2 - Even");
Console.WriteLine("3 - Calc");
Console.WriteLine("4 - GCD");
Console.WriteLine("0 - Exit");
Console.Write("Your choice: ");

string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Cli.Greeting();
        break;

    case "2":
        Even.Question();
        break;

    case "3":
        Calc.Calculator();
        break;

    case "4":
        GCD.GamesNOD();
        break;

    case "0":
        Console.WriteLine("End Game");
        break;

    default:
        Console.WriteLine("Incorrect choice!");
        break;
}
