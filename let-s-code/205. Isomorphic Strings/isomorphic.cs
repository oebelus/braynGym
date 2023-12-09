using System.Collections.Generic;
using System;
using System.Linq;

class Demo {
    public static void Main(string[] args)
    {
        string s = "egg", t = "add";
        Console.WriteLine(IsIsomorphic(s, t));
    }
    // Stopod time&space consuming solution
    static bool IsIsomorphic_stopod(string s, string t) {
        Dictionary <char, char> dictionary = new();
        int length = s.Length;
        for (int i = 0; i < length; i++) {
            if (dictionary.ContainsKey(s[i]) && dictionary[s[i]] != t[i]) {
                return false;
            }
            else if (dictionary.ContainsValue(t[i]) && !dictionary.ContainsKey(s[i])) {
                return false;
            }
            else {
                dictionary[s[i]] = t[i];
            }
        }
    return true;
    }
    // A better solution
    static bool IsIsomorphic(string s, string t) {
        Dictionary <char, char> sdict = new();
        Dictionary <char, char> tdict = new();
        int length = s.Length;
        for (int i = 0; i < length; i++) {
            if (!sdict.ContainsKey(s[i])) {
                sdict[s[i]] = t[i];
            }
            if (!tdict.ContainsKey(t[i])) {
                tdict[t[i]] = s[i];
            }
            if ((sdict.ContainsKey(s[i]) && sdict[s[i]] != t[i] ||
                tdict.ContainsKey(t[i]) && tdict[t[i]] != s[i])) {
                    return false;
            }
        }
        return true;
    }
}
