class HoofIt
{
    private static List<List<int>> Trail = [];
    private static List<int[]> Starts = [];
    private static int rows = 0;
    private static int columns = 0;
    private static int count = 0;
    private static List<int[]> Directions = [[-1, 0], [1, 0], [0, -1], [0, 1]];

    public static void Main()
    {
        ParseInput();
        FindStartIndices();

        foreach (int[] start in Starts)
        {
            // HashSet<(int, int)> reachedNines = [];
            // Trailheads(start, 0, reachedNines);
            // count += reachedNines.Count;

            Trailhead(start, 0);
        }

        Console.WriteLine(count);
    }

    public static void ParseInput()
    {
        var file = File.ReadAllLines("numbers.txt");
        int length = file.Length;

        rows = length;
        columns = file[0].Length;

        foreach (var line in file)
        {
            Trail.Add(line.Select(x => int.Parse(x.ToString())).ToList());
        }
    }

    public static void FindStartIndices()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (Trail[i][j] == 0)
                {
                    Starts.Add([i, j]);
                }
            }
        }
    }

    // part 2
    private static void Trailhead(int[] position, int current)
    {
        int x = position[0], y = position[1];

        if (Trail[x][y] == 9)
        {
            count++;
            return;
        }

        if (Trail[x][y] != current)
        {
            return;
        }

        int temp = Trail[x][y];
        Trail[x][y] = -1;

        foreach (int[] direction in Directions)
        {
            int newX = x + direction[0];
            int newY = y + direction[1];

            if (newX >= 0 && newX < rows && newY >= 0 && newY < columns &&
                Trail[newX][newY] == current + 1)
            {
                Trailhead([newX, newY], current + 1);
            }
        }

        Trail[x][y] = temp;
    }

    // part 1
    private static void Trailheads(int[] position, int current, HashSet<(int, int)> reachedNine)
    {
        int x = position[0], y = position[1];

        if (Trail[x][y] == 9)
        {
            reachedNine.Add((x, y));
            return;
        }

        if (Trail[x][y] != current)
        {
            return;
        }

        int temp = Trail[x][y];
        Trail[x][y] = -1;

        foreach (int[] direction in Directions)
        {
            int newX = x + direction[0];
            int newY = y + direction[1];

            if (newX >= 0 && newX < rows && newY >= 0 && newY < columns &&
                Trail[newX][newY] == current + 1)
            {
                Trailheads([newX, newY], current + 1, reachedNine);
            }
        }

        Trail[x][y] = temp;
    }
}