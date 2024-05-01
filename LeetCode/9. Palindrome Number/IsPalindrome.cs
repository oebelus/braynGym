public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        else {
            string number = x.ToString();
            int length = number.Length;
            int i = 0;
            int j = length - 1;
            while (i < j) {
                if (number[i] != number[j]) return false;
                i++;
                j--;
            }
        }
        return true; 
    }
}
