public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s_a = s.ToCharArray();
        char[] t_a = t.ToCharArray();
            
        Array.Sort(s_a);
        Array.Sort(t_a);

        return new string (t_a) == new string (s_a);
    }
}
