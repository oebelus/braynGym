public class Solution {
    public int MaximumStrongPairXor(int[] nums) {
        int length = nums.Length;
        
        int start = 0;
        int end;
        
        int xor = 0;
        
        while (start < length) {
            end = start;
            while (end < length) {
                if (Math.Abs(nums[start] - nums[end]) <= Math.Min(nums[start], nums[end])) {
                    xor = Math.Max(xor, nums[start] ^ nums[end]);
                }
                end++;
            }
            start++;
        }
        return xor;
    }
}
