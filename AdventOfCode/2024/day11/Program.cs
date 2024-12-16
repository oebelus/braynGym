using System.Diagnostics;

class PlutonianPebbles
{
    public static List<long> Numbers = [];
    private static readonly int blinks = 75;
    private static readonly int blinksFrequency = 25;

    public static void Main()
    {
        Stopwatch timer = Stopwatch.StartNew();

        ParseInput();

        int total = Blink(0, blinksFrequency, Numbers);

        timer.Stop();

        Console.WriteLine($"Total Stones: {total}");
        Console.WriteLine($"Seconds: {timer.Elapsed.TotalSeconds}");
    }

    private static void ParseInput()
    {
        var file = File.ReadAllText("numbers.txt");

        Numbers = file.Split(' ').Select(x => long.Parse(x.Trim())).ToList();
    }

    // Part 1
    private static int Blink(int currentBlink, int maxBlinks, List<long> stones)
    {
        if (currentBlink == maxBlinks) return stones.Count;

        int length = stones.Count;

        List<long> buffer = [];

        for (var i = 0; i < length; i++)
        {
            // find all 0s
            if (stones[i] == 0) buffer.Add(1);

            // Handle even numbers
            else if (stones[i].ToString().Length % 2 == 0 && stones[i] > 9)
            {
                int half = stones[i].ToString().Length / 2;

                buffer.Add(int.Parse(stones[i].ToString()[0..half]));
                buffer.Add(int.Parse(stones[i].ToString()[half..]));
            }

            else buffer.Add(stones[i] * 2024);
        }
        return Blink(currentBlink + 1, maxBlinks, buffer);
    }
}