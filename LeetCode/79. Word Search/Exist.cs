public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;
        int length = word.Length;
        
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols; j++) 
            {
                if (DFS(i, j, 0)) return true;
            }
        }

        return false; 
        
        bool DFS(int row, int col, int i) 
        {
            if (length == i) return true;
            
            if (row < 0 || col < 0 || row >= rows || col >= cols || board[row][col] != word[i]) {
                return false;
            }
            
            // Mark the cell as visited by altering it temporarily
            char temp = board[row][col];
            board[row][col] = '#';
            
            List<(int, int)> directions = [(1, 0), (0, 1), (-1, 0), (0, -1)];

            foreach (var (x, y) in directions)
            {
                int dx = row +  x;
                int dy = col + y;
                
                if (DFS(dx, dy, i + 1)) return true;
                
            }
            
            // Restore the original value (backtracking)
            board[row][col] = temp;
            
            return false;
        }
    }
}
