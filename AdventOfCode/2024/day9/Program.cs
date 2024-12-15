using System.Numerics;

class DiskFragmenter
{
    private static List<string> numbers = [];

    static void Main(string[] args)
    {
        ParseInput();

        CompactDisk();
        BigInteger result = GetPositions();
        Console.WriteLine(result);
    }

    private static void ParseInput()
    {
        List<char> split = [.. File.ReadAllText("numbers.txt").TrimEnd().ToCharArray()];

        int length = split.Count;

        string count = "0";
        List<string> disk = [];

        for (int i = 0; i < length; i++)
        {
            int num = int.Parse(split[i].ToString());

            if (i % 2 == 0)
            {

                for (int j = 0; j < num; j++)
                {
                    disk.Add(count);
                }

                count = $"{int.Parse(count.ToString()) + 1}";
            }
            else
            {
                for (int j = 0; j < num; j++)
                {
                    disk.Add(".");
                }
            }
        }

        numbers = disk;
    }

    private static void CompactDisk()
    {
        while (true)
        {
            int rightmostBlockIndex = numbers.LastIndexOf(numbers.Last(x => x != "."));

            int leftmostDotIndex = numbers.IndexOf(".");

            if (rightmostBlockIndex < leftmostDotIndex)
                break;

            numbers[leftmostDotIndex] = numbers[rightmostBlockIndex];
            numbers[rightmostBlockIndex] = ".";
        }
    }


    private static BigInteger GetPositions()
    {
        BigInteger result = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] != ".")
            {
                result += int.Parse(numbers[i]) * i;
            }
        }
        return result;
    }
}