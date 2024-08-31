public class Solution {
    public int MaximumStrongPairXor(int[] nums) {
        int length = nums.Length;
        
        int start = 0;
        int end = 0;
        
        HashSet<int> xor = [];
        
        while (start < length) {
            int i = start;
            end = start;
            while (end < length) {
                if (Math.Abs(nums[start] - nums[end]) <= Math.Min(nums[start], nums[end])) {
                    xor.Add(nums[start] ^ nums[end]);
                }
                end++;
            }
            start++;
        }
        return xor.Max();
    }
}
