public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);
        int i = 0;
        int j = 1;
        int length = nums.Length - 1;

        while (j <= length) {
            if (nums[i] == nums[j]) return nums[i];
            i++;
            j++;
        }
        
        return -1;
    }
}
