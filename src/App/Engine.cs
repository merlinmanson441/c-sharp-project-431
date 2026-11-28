namespace App;

public class Engine
{
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

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
