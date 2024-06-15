public static string superReducedString(string s)
{
    string pattern = "(.)\\1{1}";
    Regex rg = new Regex(pattern);
    
    if (rg.Matches(s).Count == 0) {
        return s.Length > 0 ? s : "Empty String";
    }
    else {
        string sub = Regex.Replace(s, pattern, "");
        return superReducedString(sub);
    }
}
