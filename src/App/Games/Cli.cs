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

    public static void AnswerCorrect()
    {
        Console.WriteLine("Correct!");
    }

    public static void Congratulations(string name)
    {
        Console.WriteLine($"Congratulations, {name}!");
    }

    public static void AnswerWrong(string? userAnswer, string correctAnswer, string name)
    {
        Console.WriteLine(
            $"'{userAnswer}' is wrong answer :(. Correct answer was '{correctAnswer}'."
        );
        Console.WriteLine($"Let's try again, {name}!");
    }

    public static bool CheckAnswer(string? userAnswer, string correctAnswer)
    {
        return userAnswer == correctAnswer;
    }
}
