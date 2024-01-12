public static int viralAdvertising(int n)
{
    int cum = 0;
    int count = 5;
    for (int i = 0; i < n; i++) {
        cum += count / 2;
        count = count / 2 * 3;
    }
    return cum;
}
