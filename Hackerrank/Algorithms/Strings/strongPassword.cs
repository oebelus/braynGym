public static int minimumNumber(int n, string password)
{
    int length = password.Length;
    var special = new Regex("^[a-zA-Z0-9]");
    int count = 0;

    if (!password.Any(char.IsDigit)) count++;
    if (!password.Any(char.IsUpper)) count++;
    if (!password.Any(char.IsLower)) count++;
    if (!password.Any(c => !char.IsLetterOrDigit(c))) count++;
    
    return (count + length < 6) ? 6 - n: count;
}
