public static List<int> permutationEquation(List<int> p)
{
    int length = p.Count;
    List<int> result = new(new int[length]);

    for (int i = 0; i < length; i++) {
        int index = p[i];
        result[p[p[index-1]-1]-1] = index;
    }
    return result;
}
