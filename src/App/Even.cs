public class Even
{
    public static readonly Random rand = new Random();

    public static int GeneratorRandom()
    {
        return rand.Next(1, 101);
    }

    public static void Question()
    {
        var rand = new Random();
        string userName = Cli.Greeting();
        Console.WriteLine("Answer 'yes' if the number is even, otherwise answer 'no'.");

        var i = 1;
        while (i < 4)
        {
            var random = GeneratorRandom();
            Console.WriteLine("Question: " + random);
            Console.Write("Your answer: ");
            var answer = Console.ReadLine();

            if (random % 2 == 0)
            {
                if (answer == "no")
                {
                    Console.WriteLine("'no' is wrong answer ;(. Correct answer was 'yes'.");
                    break;
                }
                if (answer == "yes")
                {
                    Console.WriteLine("Correct!");
                    i++;
                }
                else
                {
                    Console.WriteLine($"'{answer}' is wrong answer ;(. Correct answer was 'yes'.");
                    break;
                }
            }
            else
            {
                if (answer == "yes")
                {
                    Console.WriteLine("'yes' is wrong answer ;(. Correct answer was 'no'.");
                    break;
                }
                if (answer == "no")
                {
                    Console.WriteLine("Correct!");
                    i++;
                }
                else
                {
                    Console.WriteLine($"'{answer}' is wrong answer ;(. Correct answer was 'no'.");
                    break;
                }
            }
            if (i == 4)
                Console.WriteLine($"Congratulations, {userName}!");
        }
    }
}
