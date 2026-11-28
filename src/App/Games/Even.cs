namespace App.Games;

public class Even
{
    public static void Question()
    {
        var userName = Cli.Greeting();
        int countAnswer = 3;

        Console.WriteLine("Answer 'yes' if the number is even, otherwise answer 'no'.");

        var i = 1;
        while (i <= countAnswer)
        {
            var random = RandomGenerator.Generator(1, 101);
            Console.WriteLine("Question: " + random);
            Console.Write("Your answer: ");
            string? userAnswer = Console.ReadLine();

            string correctAnswer = Engine.IsEven(random) ? "yes" : "no";

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
