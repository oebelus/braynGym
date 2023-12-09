public class Solution {
    public int[] SortedSquares(int[] nums) {
        int length = nums.Length;
        var array = new int[length];
        int i = 0;
        int j = length - 1;
        for (int k = length - 1; k >= 0; k--) {
            int squared_i = nums[i]*nums[i];
            int squared_j = nums[j]*nums[j];
            if (squared_i < squared_j) {
                array[k] = squared_j;
                j--;
            }
            else {
                array[k] = squared_i;
                i++;
            }
        }
        return array;
    }
}
