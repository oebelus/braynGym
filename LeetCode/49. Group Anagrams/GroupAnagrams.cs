public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        return strs.GroupBy(c=>string.Join("", c.OrderBy(c=>c)))
            .Select(group => (IList<string>)group.ToList())
            .ToList();
    }
}
