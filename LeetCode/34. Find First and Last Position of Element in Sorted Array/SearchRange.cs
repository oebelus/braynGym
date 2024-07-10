public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        List<int> result = [];
        
        int length = nums.Length;
        
        int low = 0;
        int high = length - 1;
        
        while (low <= high) {
            int middle = (low + high) / 2;
            
            if (nums[middle] > target) {
                high = middle - 1;
                
            } else if (nums[middle] < target) {
                low = middle + 1;
                
            } else {
                if (!result.Contains(middle)) {
                    result.Add(middle);
                    
                    int left = middle - 1;
                    while (left >= 0 && nums[left] == target) {
                        result.Add(left);
                        left--;
                    }
                    
                    int right = middle + 1;
                    while (right < length && nums[right] == target) {
                        result.Add(right);
                        right++;
                    }
                    break;
                }
                else
                    break;
            }
        }
        
        return result.Count == 0 ? [-1, -1] : [result.Min(), result.Max()];
    }
}
