public static List<int> cutTheSticks(List<int> arr)
{
    List<int> size = new();
    
    if (arr.Count == 0) return size;
    size.Add(arr.Count);
    int min = arr.Min();
    arr.RemoveAll(r => r == min);
    size.AddRange(cutTheSticks(arr));
    return size;
}
