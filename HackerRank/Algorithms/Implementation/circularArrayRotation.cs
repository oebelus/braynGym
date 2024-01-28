public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{
    List<int> b = new();
    List<int> result = new();
    int length = a.Count;
    for (int i = 0; i < length; i++) {
        b.Add(a[(length - k%length + i)%length]); 
    }
    foreach (int query in queries) result.Add(b[query]);
    return result;
}
