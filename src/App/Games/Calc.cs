public class Calc
{
    public static void Calculator()
    {
        string userName = Cli.Greeting();
        Console.WriteLine("What is the result of the expression?");

        int countAnswer = 3;
        var i = 1;
        var min = 1;
        var max = 101;

        while (i <= countAnswer)
        {
            int a = RandomGenerator.Generator(min, max);
            int b = RandomGenerator.Generator(min, max);
            int operation = RandomGenerator.Generator(1, 4);

            string symbol = operation switch
            {
                1 => "+",
                2 => "-",
                3 => "*",
                _ => throw new ArgumentException("Неизвестная операция"),
            };

            int result = operation switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                _ => throw new ArgumentException("Неизвестная операция"),
            };
            Console.WriteLine($"Question: {a} {symbol} {b}");
            Console.Write("Your answer: ");
            string? userAnswer = Console.ReadLine();

            if (Cli.CheckAnswer(userAnswer, result.ToString()))
            {
                Cli.AnswerCorrect();
                i++;
            }
            else
            {
                Cli.AnswerWrong(userAnswer, result.ToString(), userName);
                break;
            }
            if (i == countAnswer + 1)
            {
                Cli.Congratulations(userName);
                break;
            }
        }
    }
}
