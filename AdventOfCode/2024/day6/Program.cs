class GuardGallivant
{
    private static readonly List<List<char>> matrix = [];
    private static int rows = 0;
    private static int cols = 0;
    private static List<int> playerPosition = [];
    private static HashSet<string> visited = [];

    enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    private readonly static Dictionary<Direction, List<int>> directions = new() {
        { Direction.UP, [0, -1] },
        { Direction.DOWN, [0, 1] },
        { Direction.LEFT, [-1, 0] },
        { Direction.RIGHT, [1, 0] }
    };

    private static Direction currentDirection = Direction.UP;

    public static void Main(string[] args)
    {
        ParseInput();

        playerPosition = FindPlayerPosition();

        Console.WriteLine(rows + " " + cols);

        visited.Add($"{playerPosition[0]} {playerPosition[1]}");

        SolveMaze();

        Console.WriteLine(visited.Count);
    }

    private static void ParseInput()
    {
        var lines = File.ReadAllLines("./maze.txt");

        foreach (var line in lines)
        {
            matrix.Add([.. line.ToCharArray()]);
        }

        rows = matrix.Count;
        cols = matrix[0].Count;
    }

    private static List<int> FindPlayerPosition()
    {
        foreach (var row in matrix)
        {
            var col = row.IndexOf('^');
            if (col != -1)
            {
                return [row.IndexOf('^'), matrix.IndexOf(row)];
            }
        }
        return [];
    }

    private static void SolveMaze()
    {
        while (playerPosition[0] < cols && playerPosition[0] >= 0 && playerPosition[1] < rows && playerPosition[1] >= 0)
        {
            int c = playerPosition[0] + directions[currentDirection][0];
            int r = playerPosition[1] + directions[currentDirection][1];

            if (r >= rows || c >= cols || r < 0 || c < 0) break;

            //Console.WriteLine(playerPosition[0]);
            Console.WriteLine($"{playerPosition[0]} {playerPosition[1]} {matrix[r][c]} {currentDirection}");

            if (matrix[r][c] == '#')
            {
                currentDirection = currentDirection switch
                {
                    Direction.UP => Direction.RIGHT,
                    Direction.DOWN => Direction.LEFT,
                    Direction.LEFT => Direction.UP,
                    Direction.RIGHT => Direction.DOWN,
                    _ => currentDirection
                };
            }

            playerPosition[0] += directions[currentDirection][0];
            playerPosition[1] += directions[currentDirection][1];

            visited.Add($"{playerPosition[0]} {playerPosition[1]}");
        }
    }
}