public static int saveThePrisoner(int n, int m, int s)
{
    int result = (m - 1 + s) % n;
    if (result == 0) result = n;
    return result; 
}
