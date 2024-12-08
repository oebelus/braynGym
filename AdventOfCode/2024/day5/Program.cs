using System.Reflection.Metadata.Ecma335;

class PrintQueue
{
    private static Dictionary<int, List<int>> adjacency = [];
    private static List<List<int>> paths = [];
    private static int correct = 0;
    private static int incorrect = 0;

    public static void Main()
    {
        ParseInput();

        foreach (List<int> path in paths)
        {
            if (CheckPath(path)) correct += path[path.Count / 2];
            else
            {
                incorrect += InsertionSort(path);
            }
        }

        Console.WriteLine(correct);
        Console.WriteLine(incorrect);
    }

    public static void ParseInput()
    {
        var lines = File.ReadLines("numbers.txt");

        foreach (string line in lines)
        {
            if (line.Contains('|'))
            {
                var parts = line.Split('|').Select(int.Parse).ToList();

                if (adjacency.ContainsKey(parts[0]))
                {
                    adjacency[parts[0]].Add(parts[1]);
                }
                else
                {
                    adjacency[parts[0]] = [parts[1]];
                }
            }
            else if (line.Contains(','))
            {
                paths.Add(line.Split(',').Select(int.Parse).ToList());
            }
        }

    }

    // Part 1
    public static bool CheckPath(List<int> path)
    {
        int length = path.Count;

        for (int i = 0; i < length - 1; i++)
        {
            if (!adjacency.ContainsKey(path[i]) || !adjacency[path[i]].Contains(path[i + 1]))
            {
                return false;
            }
        }

        return true;
    }

    // part 2
    public static int InsertionSort(List<int> path)
    {
        int length = path.Count;

        for (int i = 1; i < length; i++)
        {
            int key = path[i];
            int j = i - 1;

            if (!adjacency.ContainsKey(key)) continue;

            while (j >= 0 && adjacency[key].Contains(path[j]))
            {
                path[j + 1] = path[j];
                j -= 1;
            }

            path[j + 1] = key;
        }

        return path[length / 2];
    }
}