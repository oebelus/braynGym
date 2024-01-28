public static List<int> quickSort(List<int> arr)
{
    List<int> more = new();
    List<int> less = new();
    int pivot = arr[0];
    for (int i = 0; i < arr.Count; i++) {
        if (arr[i] > pivot) more.Add(arr[i]);
        else if (arr[i] < pivot) less.Add(arr[i]);
        
    }
    less.Add(pivot);
    for (int i = 0; i < more.Count; i++) less.Add(more[i]);
    return less;
}
