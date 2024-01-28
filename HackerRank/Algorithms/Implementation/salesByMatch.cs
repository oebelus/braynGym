public static int sockMerchant(int n, List<int> ar)
{
    Dictionary<int, int> dic = new();
    int count = 0;
    for (int i = 0; i < n; i++) {
        if (!dic.ContainsKey(ar[i])) {
            dic[ar[i]] = 1; 
        } else dic[ar[i]] += 1;
    }
    foreach (var el in dic.Keys) {
        //Console.WriteLine(dic[el]);
        count += dic[el] / 2;
    }
    return count;
}
