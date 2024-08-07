public class Solution {
    public bool ValidPalindrome(string s) {
        int low = 0, high = s.Length - 1;

        while (low < high) {
            if (s[low] == s[high]) {
                low++;
                high--;
            } else {
                return IsPalindrome(s, low + 1, high) || IsPalindrome(s, low, high - 1);
            }
        }
        return true;
    }

    public bool IsPalindrome(string s, int low, int high) {
        while (low < high) {
            if (s[low] != s[high]) return false;
            low++;
            high--;
        }
        return true;
    }
}
