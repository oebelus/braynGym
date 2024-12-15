class PlutonianPebbles
{
    public static List<long> Numbers = [];
    private static readonly int blinks = 25;

    public static void Main()
    {
        ParseInput();
        Console.WriteLine(Blink(0, Numbers));
    }

    private static void ParseInput()
    {
        var file = File.ReadAllText("numbers.txt");

        Numbers = file.Split(' ').Select(x => long.Parse(x.Trim())).ToList();
    }

    // Part 1
    private static int Blink(int currentBlink, List<long> stones)
    {
        if (currentBlink == blinks) return stones.Count;

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
        return Blink(currentBlink + 1, buffer);
    }
}