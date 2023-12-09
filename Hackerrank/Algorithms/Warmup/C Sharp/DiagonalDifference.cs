using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<List<int>> matrix = new List<List<int>> {
            new List <int> {11, 2, 4},
            new List <int> {4, 5, 6},
            new List <int> {10, 8, -12}
        };
        int result = diagonalDifference(matrix);
        Console.WriteLine("Absolute Diagonal Difference: " + result);
    }
    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumLeft = 0;
        int sumRight = 0;
        for (int i = 0; i < arr.Count; i++) {
            sumLeft += arr[i][i];
            sumRight += arr[i][arr.Count - 1 - i];
        }
        return Math.Abs(sumLeft-sumRight);
    }
}
