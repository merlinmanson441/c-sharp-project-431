namespace App.Games;

public class Progression
{
    public static string[] CreateRange()
    {
        var start = RandomGenerator.Generator(1, 101);
        var step = RandomGenerator.Generator(1, 11);
        var lentgth = RandomGenerator.Generator(5, 11);

        var range = new string[lentgth];

        for (var i = 0; i < lentgth; i++)
        {
            range[i] = (start + i * step).ToString();
        }
        return range;
    }

    public static void Question()
    {
        int countAnswer = 3;
        var i = 1;

        var userName = Cli.Greeting();
        Console.WriteLine("What number is missing in the progression?");

        while (i <= countAnswer)
        {
            var range = CreateRange();
            var randomIndex = RandomGenerator.Generator(1, range.Length + 1) - 1;
            var correctAnswer = range[randomIndex];
            range[randomIndex] = "..";

            Console.WriteLine($"Question: {String.Join(" ", range, 0, range.Length)}");
            Console.Write("Your answer: ");

            var userAnswer = Console.ReadLine();

            if (Engine.CheckAnswer(userAnswer, correctAnswer))
            {
                i++;
                Engine.AnswerCorrect();
            }
            else
            {
                Engine.AnswerWrong(userAnswer, correctAnswer, userName);
                break;
            }
            if (i == countAnswer + 1)
            {
                Engine.Congratulations(userName);
                break;
            }
        }
    }
}
