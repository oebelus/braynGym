public static int camelcase(string s)
{
    int length = s.Length;
    int count = 1;
    for (int i = 0; i < length; i++) {
        if (Char.IsUpper(s[i])) count++;
    }
    return count;
}

// return s.Count(char.IsUpper) + 1;
