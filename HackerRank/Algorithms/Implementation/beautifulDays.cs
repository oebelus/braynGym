public static int beautifulDays(int i, int j, int k)
{
    int count = 0;
    for (int l = i; l <= j; l++) {
        if (Math.Abs(l - reverse(l)) % k == 0) count++;
    }
    return count;
}

public static int reverse(int k) {
    int rev_num = 0;
    while (k > 0) {
        rev_num = rev_num * 10 + k % 10;
        k = k / 10;
    }
    return rev_num;
}
