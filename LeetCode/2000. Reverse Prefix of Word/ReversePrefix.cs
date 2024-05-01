public class Solution {
    public string ReversePrefix(string word, char ch) {
        int length = word.Length;
        string toRev = "";
        int i = 0;
        while (word[i] != ch &&  i < length - 1) {
            toRev += word[i];
            i++;
            if (i == length - 1 && word[i] != ch) return word;
        }
        toRev += word[i];
        
        return String.Join("", toRev.Reverse()) + word.Substring(i+1, length-i-1);
    }
}
