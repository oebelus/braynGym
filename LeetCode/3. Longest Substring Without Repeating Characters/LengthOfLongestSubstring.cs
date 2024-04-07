public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int i = 0;
        int j = 0;
        int max = 0;
        int length = s.Length;
        
        List<char> set = new();
        
        while (j < length) {
            if (!set.Contains(s[j])) {
                set.Add(s[j]);
                j++;
                max = Math.Max(set.Count, max);
            } else {
                set.Remove(s[i]);
                i++;
            }
        } 
        return max;
    }
}
