public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        int length = nums.Length - 1;
        var permutations = new List<IList<int>>();
        return DoPermute(nums, 0, length, permutations);
    }
    private static IList<IList<int>> DoPermute(int[] nums, int start, int end, List<IList<int>> list) {
        if (start == end)
            list.Add(new List<int>(nums));
        else {
            for (int i = start; i <= end; i++) {
                Swap(ref nums[i], ref nums[start]);
                DoPermute(nums, start + 1, end, list);
                Swap(ref nums[i], ref nums[start]);
            }
        }
        return list;
    }
    private static void Swap(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;
    }
}
