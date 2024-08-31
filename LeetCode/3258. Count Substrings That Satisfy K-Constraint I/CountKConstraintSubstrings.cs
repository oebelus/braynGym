public class Solution {
    public int CountKConstraintSubstrings(string s, int k) {
        int length = s.Length;
        int count = 0;
        
        for (int start = 0; start < length; start++) {
            int zeroes = 0;
            int ones = 0;
            
            for (int end = start; end < length; end++) {
                if (s[end] == '1') ones++; else zeroes++;
                
                if (ones <= k || zeroes <= k) count++;
            }
        }
        
        return count;
    }
}
