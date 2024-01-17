using System.Collections.Generic;

class Demo {
    public static void Main(string[] args)
    {
        int[] nums = {2,7, 11, 15};
        TwoSum(nums, 9);
    }
    static int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> dictionary = new Dictionary<int, int>();
        int length = nums.Length;
        for (int i = 0; i < length; i++) {
            int num = target - nums[i];
            if (dictionary.TryGetValue(num, out int index)) {
                return new int[] {index, i};
            }
            else dictionary[nums[i]] = i;
        }
        return new int [2];
    }
}
