public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int length = nums.Length;
        Dictionary<int, int> hash = [];

        for (int i = 0; i < length; i++) {
            int diff = target - nums[i];
            if (hash.ContainsKey(nums[i])) {
                return new int[] {hash[nums[i]], i};
            }
            else {
                if (!hash.ContainsKey(diff))
                    hash.Add(diff, i);
            }  
        }

        return new int[] {}; 
    }
}
