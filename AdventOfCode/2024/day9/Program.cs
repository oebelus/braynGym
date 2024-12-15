using System.Numerics;

class DiskFragmenter
{
    private static List<int> numbers = [];

    static void Main()
    {
        ParseInput();

        CompactDisk();
        long result = CheckSum();
        Console.WriteLine(result);
    }

    private static void ParseInput()
    {
        List<char> split = [.. File.ReadAllText("numbers.txt").TrimEnd().ToCharArray()];

        int length = split.Count;

        int count = 0;
        List<int> disk = [];

        for (int i = 0; i < length; i++)
        {
            int num = int.Parse(split[i].ToString());

            if (i % 2 == 0)
            {

                for (int j = 0; j < num; j++)
                {
                    disk.Add(count);
                }

                count++;
            }
            else
            {
                for (int j = 0; j < num; j++)
                {
                    disk.Add(-1);
                }
            }
        }

        numbers = disk;
    }

    private static void CompactDisk()
    {
        while (true)
        {
            int rightmostBlockIndex = numbers.LastIndexOf(numbers.Last(x => x != -1));

            int leftmostDotIndex = numbers.IndexOf(-1);

            if (rightmostBlockIndex < leftmostDotIndex)
                break;

            numbers[leftmostDotIndex] = numbers[rightmostBlockIndex];
            numbers[rightmostBlockIndex] = -1;
        }
    }

    // Part 1
    private static long CheckSum()
    {
        long result = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] != -1)
                result += numbers[i] * i;
        }
        return result;
    }
}