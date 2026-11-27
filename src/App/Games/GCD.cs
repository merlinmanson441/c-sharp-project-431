namespace App.Games;
public class GCD
{
    public static int NOD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            var rest = a % b;
            a = b;
            b = rest;
        }
        return a;
    }

    public static void GamesNOD()
    {
        var min = 1;
        var max = 101;
        int countAnswer = 3;
        var i = 1;
        var userName = Cli.Greeting();

        Console.WriteLine("Find the greatest common divisor of given numbers.");

        while (i <= countAnswer)
        {
            var firstNumber = RandomGenerator.Generator(min, max);
            var secondNumber = RandomGenerator.Generator(min, max);
            Console.WriteLine($"Question: {firstNumber} {secondNumber}");
            Console.Write("Your answer: ");
            var userAnswer = Console.ReadLine();
            var correctAnswer = NOD(firstNumber, secondNumber).ToString();

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
