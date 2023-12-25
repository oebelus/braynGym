public static List<int> rotateLeft(int d, List<int> arr)
{
    List <int> list = new List<int>();
    int length = arr.Count;
    for (int i = 0; i < length; i++) {
        list.Add(arr[(length + d + i)%length]);
    }
    return list;
}
