using System.Reflection.Metadata.Ecma335;

class PrintQueue
{
    private static Dictionary<int, List<int>> adjacency = [];
    private static List<List<int>> paths = [];
    private static int count = 0;

    public static void Main()
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

        foreach (var (key, value) in adjacency)
        {
            Console.Write($"{key}: ");

            foreach (var item in value)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        foreach (List<int> path in paths)
        {
            count += CheckPath(path) ? path[path.Count / 2] : 0;
        }

        Console.WriteLine(count);
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
}