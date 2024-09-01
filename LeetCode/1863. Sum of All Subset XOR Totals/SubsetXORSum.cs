public class Solution {
    public int SubsetXORSum(int[] nums) {
        HashSet<List<int>> subsets = [];
        int length = nums.Length;
        int xor = 0;
        
        Subsets(new List<int>(nums), subsets, [], 0);   
        
        foreach (var item in subsets)
        {
            int x = 0;
            foreach (var num in item)
            {
                x ^= num;
            }
            xor += x;
        }

        return xor;
    }
    static void Subsets(List<int> nums, HashSet<List<int>> subsets, List<int> subset, int start) {
        subsets.Add(new List<int>(subset));
        
        for (int i = start; i < nums.Count; i++) {
            subset.Add(nums[i]);
            
            Subsets(nums, subsets, subset, i + 1);
            
            subset.RemoveAt(subset.Count - 1);
        }
    }
}
