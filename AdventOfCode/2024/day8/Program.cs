class Collinearity
{
    private static List<List<char>> matrix = [];
    private static int rows = 0;
    private static int cols = 0;

    public static void Main()
    {
        ParseInput();

        Dictionary<char, List<List<int>>> positions = GetPositions();

        CountUnique(positions);

        CountAntennas(positions);
    }

    private static void ParseInput()
    {
        var input = File.ReadAllLines("numbers.txt");

        for (int i = 0; i < input.Length; i++)
        {
            matrix.Add([.. input[i].ToCharArray()]);
        }

        rows = matrix.Count;
        cols = matrix[0].Count;
    }


    private static Dictionary<char, List<List<int>>> GetPositions()
    {
        Dictionary<char, List<List<int>>> positions = [];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                char letter = matrix[i][j];

                if (letter != '.')
                {
                    if (positions.ContainsKey(letter))
                    {
                        positions[letter].Add([i, j]);
                    }
                    else
                    {
                        positions.Add(letter, [[i, j]]);
                    }
                }
            }
        }

        return positions;
    }

    private static List<List<List<int>>> GetCombinations(List<List<int>> positions)
    {
        List<List<List<int>>> combinations = [];

        for (int i = 0; i < positions.Count; i++)
        {
            for (int j = i + 1; j < positions.Count; j++)
            {
                combinations.Add([positions[i], positions[j]]);
            }
        }

        return combinations;
    }

    // Part 1
    private static int CountUnique(Dictionary<char, List<List<int>>> positions)
    {
        int count = 0;
        HashSet<string> set = [];

        foreach (var (key, val) in positions)
        {
            List<List<List<int>>> combinations = GetCombinations(val);
            int length = combinations.Count;

            for (int i = 0; i < length; i++)
            {

                int x1 = combinations[i][0][0];
                int y1 = combinations[i][0][1];
                int x2 = combinations[i][1][0];
                int y2 = combinations[i][1][1];

                int dx = x2 - x1;
                int dy = y2 - y1;

                int px1 = x1 - dx;
                int py1 = y1 - dy;

                int px2 = x2 + dx;
                int py2 = y2 + dy;

                string key1 = $"{px1},{py1}";
                string key2 = $"{px2},{py2}";

                if (px1 < cols && px1 >= 0 && py1 < rows && py1 >= 0 && !set.Contains(key1))
                {
                    set.Add(key1);
                    count++;
                }
                if (px2 < cols && px2 >= 0 && py2 < rows && py2 >= 0 && !set.Contains(key2))
                {
                    set.Add(key2);
                    count++;
                }
            }
        }
        Console.WriteLine(count);
        return count;
    }

    // Part 2
    private static int CountAntennas(Dictionary<char, List<List<int>>> positions)
    {
        int count = 0;
        HashSet<string> set = [];

        foreach (var (key, val) in positions)
        {
            List<List<List<int>>> combinations = GetCombinations(val);
            int length = combinations.Count;

            for (int i = 0; i < length; i++)
            {

                int x1 = combinations[i][0][0];
                int y1 = combinations[i][0][1];
                int x2 = combinations[i][1][0];
                int y2 = combinations[i][1][1];

                int dx = x2 - x1;
                int dy = y2 - y1;

                int px1 = x1, py1 = y1;

                while (px1 < cols && px1 >= 0 && py1 < rows && py1 >= 0)
                {
                    if (!set.Contains($"{px1},{py1}"))
                    {
                        set.Add($"{px1},{py1}");
                        count++;
                    }

                    px1 -= dx;
                    py1 -= dy;
                }

                int px2 = x2, py2 = y2;

                while (px2 < cols && px2 >= 0 && py2 < rows && py2 >= 0)
                {
                    if (!set.Contains($"{px2},{py2}"))
                    {
                        set.Add($"{px2},{py2}");
                        count++;
                    }

                    px2 += dx;
                    py2 += dy;
                }
            }
        }
        Console.WriteLine(count);
        return count;
    }
}