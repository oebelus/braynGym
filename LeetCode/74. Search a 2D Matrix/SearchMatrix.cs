public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach (var m in matrix) {
            foreach (var x in m) {
                if (x == target) return true;
            }
        }
        return false;
    }
}
