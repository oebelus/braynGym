public static IList<int> LuckyNumbers (int[][] matrix) {
    IList<int> list = [];
    
    int rows = matrix.Length;
    int cols = matrix[0].Length;
        
    int row = 0;
    
    while (row < rows) {
        int min = matrix[row].Min();
        int col = Array.IndexOf(matrix[row], min);
        
        bool isLucky = true;
        int i = 0;
        
        while (i < rows) {
            if (matrix[i][col] > min) {
                isLucky = false;
                break;
            }
            i++;
        }
        
        if (isLucky) list.Add(min);
                
        row++;
    }
    return list;
}
