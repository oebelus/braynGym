class Ceres
{
    public static List<List<char>> matrix = File.ReadLines("words.txt").ToList().Select(line => line.ToCharArray().ToList()).ToList();
    public readonly static List<int[]> directions = [[-1, 0], [1, 0], [0, -1], [0, 1], [-1, -1], [-1, 1], [1, -1], [1, 1]];

    public readonly static List<int[]> diagonals = [[-1, -1], [-1, 1], [1, -1], [1, 1]];

    private readonly static int rows = matrix.Count;
    private readonly static int columns = matrix[0].Count;
    private readonly static string toFind = "XMAS";

    public static void Main()
    {
        Console.WriteLine(FindA());
    }

    // 1. First Challenge 

    public static int FindOccurences()
    {
        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i][j] == toFind[0])
                {
                    count += FindWord(i, j);
                }
            }
        }

        return count;
    }

    public static int FindWord(int i, int j)
    {
        int occurences = 0;

        foreach (var direction in directions)
        {
            int k = i;
            int l = j;
            int charIndex = 0;

            while (charIndex < toFind.Length)
            {
                if (k < 0 || k >= rows || l < 0 || l >= columns ||
                    matrix[k][l] != toFind[charIndex])
                {
                    break;
                }

                charIndex++;
                k += direction[0];
                l += direction[1];

            }

            if (charIndex == toFind.Length) occurences++;
        }

        return occurences;
    }

    // 2. Second Challenge (Incomplete)
    public static int FindA()
    {
        int count = 0;
        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 1; j < columns - 1; j++)
            {
                if (matrix[i][j] == 'A')
                {
                    count += FindCross(i, j) ? 1 : 0;
                }
            }
        }
        return count;
    }
    public static bool FindCross(int i, int j)
    {
        char topLeft = matrix[i - 1][j - 1];
        char topRight = matrix[i - 1][j + 1];
        char bottomLeft = matrix[i + 1][j - 1];
        char bottomRight = matrix[i + 1][j + 1];
        if (((topLeft == 'M' && bottomRight == 'S') || (topLeft == 'S' && bottomRight == 'M')) &&
            ((topRight == 'M' && bottomLeft == 'S') || (topRight == 'S' && bottomLeft == 'M')))
        {
            return true;
        }
        return false;
    }

}