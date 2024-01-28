public static List<int> dynamicArray(int n, List<List<int>> queries)
{
    List<List<int>> arr = new();
    for (int j = 0; j < n; j++) {
        arr.Add(new List<int>());
    }
    int lastAnswer = 0;
    List<int> ans = new();
    for (int i = 0; i < queries.Count; i++) {
        int idx = (queries[i][1] ^ lastAnswer) % n;
        if (queries[i][0] == 1) {
            arr[idx].Add(queries[i][2]);
        } else {
            lastAnswer = arr[idx][queries[i][2] % arr[idx].Count];
            ans.Add(lastAnswer);
        }
    }
    return ans;
}
