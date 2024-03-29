public static long repeatedString(string s, long n)
{
    int occ = s.Count(c => c == 'a');
    int length = s.Length;
    long occMod = n % length;
    int stringMod = s[..(int)occMod].Count(c => c == 'a');
    return n / length * occ + stringMod;
}
