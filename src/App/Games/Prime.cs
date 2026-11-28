namespace App.Games;

public class Prime
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Question()
    {
        var userName = Cli.Greeting();
        int countAnswer = 3;

        Console.WriteLine("Answer 'yes' if given number is prime. Otherwise answer 'no'.");

        var i = 1;
        while (i <= countAnswer)
        {
            var random = RandomGenerator.Generator(1, 101);
            Console.WriteLine("Question: " + random);
            Console.Write("Your answer: ");
            string? userAnswer = Console.ReadLine();

            string correctAnswer = IsPrime(random) ? "yes" : "no";

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
