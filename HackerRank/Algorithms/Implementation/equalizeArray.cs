public static int equalizeArray(List<int> arr)
{
    Dictionary<int, int> count = new();
    foreach (int el in arr) {
        if (count.ContainsKey(el)) {
            count[el]++;
        } else {
            count[el] = 0;
        }
    }
    int max = count.OrderByDescending(x => x.Value).First().Value;
    return arr.Count - max - 1;
}
