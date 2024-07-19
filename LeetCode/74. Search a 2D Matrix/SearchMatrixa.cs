public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cols = matrix.Length;
        int rows = matrix[0].Length;
        
        int col = 0;
        int row = rows - 1;
        
        while (col < cols && row > -1) {
            if (matrix[col][row] == target) return true;
            if (matrix[col][row] < target) col++;
            else row--;
        }
        
        return false;
    }
}
