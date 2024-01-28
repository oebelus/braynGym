public static List<int> countingSort(List<int> arr)
{
    List<int> ans = new(new int[100]);
    List<int> sorted = new();
    foreach (int el in arr) {
        ans[el] += 1;
    }
    int length = ans.Count;
    for (int i = 0; i < length; i++) {
       if (ans[i] != 0) {
           while (ans[i] > 0) {
               sorted.Add(i);
               ans[i]--;
           }
       }
    }
    return sorted;
}
