public static List<int> matchingStrings(List<string> stringList, List<string> queries)
{
    List<int> ans = new();
    for (int i = 0; i < queries.Count; i++) {
        int count = 0;
        foreach (string el in stringList) {
            if (el == queries[i])
                count++;
        }
        ans.Add(count);
        count = 0;
    }
    return ans;
}
