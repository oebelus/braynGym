public static int pickingNumbers(List<int> a)
{
   List<int> ans = new();
    int length = a.Count;
    for (int i = 0; i < length; i++) {
        int count = 1;
        for (int j = 0; j < length; j++) {
            if (i != j && (a[i] == a[j] + 1 || a[i] == a[j])) count++;
        }
        ans.Add(count);
    }
    //foreach (int el in ans) Console.WriteLine(el);
    return ans.Max();
}
