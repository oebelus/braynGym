class GardenGroups
{
    private static List<List<char>> Fences = [];
    private static List<string> VisitedFences = [];
    private static int Rows = 0;
    private static int Cols = 0;
    private static int Stats = 0;

    public static void Main()
    {
        ParseInput();

        NumberOfFences();

        Console.WriteLine(Stats);
    }

    private static void ParseInput()
    {
        var file = File.ReadAllLines("garden.txt");

        Rows = file.Length;
        Cols = file[0].Length;

        for (int i = 0; i < Rows; i++)
        {
            Fences.Add([.. file[i].ToCharArray()]);
        }
    }

    private static void NumberOfFences()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                var coordinates = FloodFill(i, j, Fences[i][j], [], new bool[Rows, Cols]);

                string key = "";

                coordinates.Sort((a, b) =>
                {
                    if (a[0] == b[0])
                        return a[1].CompareTo(b[1]);
                    return a[0].CompareTo(b[0]);
                });

                foreach (var coordinate in coordinates)
                {
                    key += $"{coordinate[0]}-{coordinate[1]}";
                }

                if (!VisitedFences.Contains(key))
                {
                    VisitedFences.Add(key);

                    int area = coordinates.Count;
                    int perimeter = CalculatePerimeter(coordinates);

                    Stats += area * perimeter;
                }
                else
                {
                    continue;
                }
            }
        }
    }

    private static List<List<int>> FloodFill(int row, int col, char flower, List<List<int>> coordinates, bool[,] visited)
    {
        if (row < 0 || row >= Rows || col < 0 || col >= Cols || visited[row, col] || Fences[row][col] != flower) return coordinates;

        visited[row, col] = true;
        coordinates.Add([row, col]);

        // getting coordinates 
        FloodFill(row - 1, col, flower, coordinates, visited);
        FloodFill(row + 1, col, flower, coordinates, visited);
        FloodFill(row, col - 1, flower, coordinates, visited);
        FloodFill(row, col + 1, flower, coordinates, visited);

        return coordinates;
    }

    private static int CalculatePerimeter(List<List<int>> coordinates)
    {
        int perimeter = 0;

        HashSet<string> coordinateSet = [];

        foreach (var coord in coordinates)
        {
            coordinateSet.Add($"{coord[0]}-{coord[1]}");
        }

        foreach (var coord in coordinates)
        {
            int row = coord[0];
            int col = coord[1];

            // If a neighbour is missing, it's an edge ;)
            if (!coordinateSet.Contains($"{row - 1}-{col}")) perimeter++;
            if (!coordinateSet.Contains($"{row + 1}-{col}")) perimeter++;
            if (!coordinateSet.Contains($"{row}-{col - 1}")) perimeter++;
            if (!coordinateSet.Contains($"{row}-{col + 1}")) perimeter++;
        }

        return perimeter;
    }

}

/* 
    area: number of plots
    perimeter: number of sides that do not touch another garden plot in the same region
*/