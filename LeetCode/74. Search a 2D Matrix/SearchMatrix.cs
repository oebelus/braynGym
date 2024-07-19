public class Solution {
    // Naive, O(n . m)
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach (var m in matrix) {
            foreach (var x in m) {
                if (x == target) return true;
            }
        }
        return false;
    }

    // O(n + m)
    public bool SearchMatrix_1(int[][] matrix, int target) {
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

    // O(m log(n))
    public bool SearchMatrix_2(int[][] matrix, int target) {
        int cols = matrix.Length,
        rows = matrix[0].Length;
        
        for (int col = 0; col < cols; col++) {
            if (matrix[col][0] <= target && matrix[col][rows-1] >= target)
                return BinarySearch(matrix[col], target);       
        }
        return false;
    }

    public static bool BinarySearch(int[] nums, int target) {
        int n = nums.Length;
        int low = 0, high = n - 1;

        while (low <= high) {
            int mid = (low + high) / 2;
            if (nums[mid] == target) return true;
            else if (target > nums[mid]) low = mid + 1;
            else high = mid - 1;
            }
        return false;
    }
}
