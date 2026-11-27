public class RandomGenerator
{
    public static readonly Random rand = new Random();

    public static int Generator(int min, int max)
    {
        return rand.Next(min, max);
    }
}
