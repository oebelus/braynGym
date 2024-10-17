public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int length = numbers.Length;
        Dictionary<int, int> indices = [];
        int difference;
        
        for (int i = 0; i < length; i++) {
            difference = target - numbers[i];
            
            if (indices.ContainsKey(difference)) {
                return [indices[difference] + 1, i+1];
            } 
            
            indices[numbers[i]] = i;
        }           
        return [];
    }
}
