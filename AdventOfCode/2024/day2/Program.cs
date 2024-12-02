class Day2
{
    public static void Main()
    {
        var lines = File.ReadLines("reports.txt");
        int count = 0;

        foreach (string line in lines)
        {
            int[] parts = line.Split(" ").Select(x => int.Parse(x.Trim())).ToArray();

            if (IsSafe(parts))
            {
                count++;
            }
            else
            {
                for (int i = 0; i < parts.Length; i++)
                {
                    List<int> new_parts = [.. parts];
                    new_parts.RemoveAt(i);

                    if (IsSafe([.. new_parts]))
                    {
                        count++;
                        break;
                    }
                }
            }
        }

        Console.WriteLine(count);
    }

    public static bool IsSafe(int[] a)
    {
        int[] parts_asc = [.. a];
        Array.Sort(parts_asc);

        int[] parts_desc = [.. a];
        Array.Sort(parts_desc);
        var desc = parts_desc.Reverse();

        if (parts_asc.SequenceEqual(a) || desc.SequenceEqual(a))
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((Math.Abs(a[i] - a[i + 1]) > 3) ||
                    (Math.Abs(a[i] - a[i + 1]) < 1))
                {
                    return false;
                }
            }
            return true;
        }

        return false;
    }
}