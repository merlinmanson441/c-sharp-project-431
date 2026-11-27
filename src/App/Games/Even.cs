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
            var userAnswer = Console.ReadLine();

            var checkAnswer = random % 2 == 0 ? "yes" : "no";

            if (Cli.CheckAnswer(userAnswer, checkAnswer))
            {
                i++;
                Cli.AnswerCorrect();
            }
            else
            {
                Cli.AnswerWrong(userAnswer, checkAnswer, userName);
                break;
            }
            if (i == countAnswer + 1)
            {
                Console.WriteLine($"Congratulations, {userName}!");
                break;
            }
        }
    }
}
