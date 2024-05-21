public class Solution {
    public string DecodeString(string str) {
        Dictionary <int, int> brackets = Brackets(str);
        
        if (!str.Contains('[')) {
            return str;
        }
        else {
            int index = getDigit(str, brackets.ElementAt(0).Key-1);
            string factor = str.Substring(index, brackets.ElementAt(0).Key-index);
            string toFactor = str.Substring(brackets.ElementAt(0).Key+1, brackets.ElementAt(0).Value - brackets.ElementAt(0).Key - 1);
            string inside = str.Substring(index, brackets.ElementAt(0).Value - index + 1);
            string ans = string.Join("", Enumerable.Repeat(toFactor , int.Parse(factor)));
            return DecodeString(str.Replace(inside, ans));
        }
    }
    public static Dictionary<int, int> Brackets(string str) {
        Dictionary<int, int> brackets = [];
        Stack<int> stack = [];
        
        int length = str.Length;
        int j = 0;
        while (j < length) {
            if (str[j] == '[') stack.Push(j);
            if (str[j] == ']') {
                int start = stack.Pop();
                brackets[start] = j;
            }
            j++;
        }
        return brackets;
    }
    public static int getDigit(string str, int index) {
        int i = index;
        while (i >= 0 && char.IsDigit(str[i])) {
           i--;
        }
        return i+1;
    }
}
