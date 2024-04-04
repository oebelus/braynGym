public class Solution {
    public bool IsPalindrome(string s) {
        int slength = s.Length;
        int ptr1 = 0;
        int ptr2 = slength - 1;

        while (ptr1 < ptr2) {
            if (!char.IsLetterOrDigit(s[ptr1]) || s[ptr1] == ' ') ptr1++;
            else if (!char.IsLetterOrDigit(s[ptr2]) || s[ptr2] == ' ') ptr2--;
            else {
                if (char.ToLower(s[ptr1]) != char.ToLower(s[ptr2])) {
                    return false;
                }
                ptr1++;
                ptr2--;
            }
        }
        return true; 
    }
}
