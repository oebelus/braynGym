public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool increasing = true;
        bool decreasing = true; 
        int length = nums.Length;
        for (int i = 0; i < length - 1; i++) {
            if (nums[i] < nums[i + 1])
                decreasing = false;
        }
        for (int i = 0; i < length - 1; i++) {
            if (nums[i] > nums[i + 1])
                increasing = false;
        }
        return increasing||decreasing;
    }
}
