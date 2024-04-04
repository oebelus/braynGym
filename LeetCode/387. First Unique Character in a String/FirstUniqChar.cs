// Solution 1
static int FirstUniqChar(string s) 
{
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    int alphlength = alphabet.Length;
    int slength = s.Length;
    int ans = 0;
    int[] index = new int[alphlength];
    for (int i = 0; i < slength; i++) {
        index[alphabet.IndexOf(s[i])]+=1;
    }
    for (int j = 0; j < slength; j++) {
        if (index[alphabet.IndexOf(s[j])] == 1) {
            ans = j;
            break;
        } else ans = -1;
    }
    return ans;
}

// Solution 2 O(n^2)
static int FirstUniqChart(string s) {
    int slength = s.Length;
    for (int i = 0; i < slength; i++) {
        char pointer = s[i];
        int j = 0;
        while (j < slength) {
            if (pointer == s[j] && j != i) { 
                break;
            } else if (j == slength - 1) return i;
            j++;
        }
    }
    return -1;
}

// Solution 3, Dictionary Solution O(n)
public int FirstUniqCharte(string s) {
    Dictionary<char, int> hashmap = [];
    int slength = s.Length;
    for (int i = 0; i < slength; i++) {
        if (hashmap.ContainsKey(s[i])) {
            hashmap[s[i]] += 1;
        } else hashmap[s[i]] = 0;
    }
    foreach (var (key, val) in hashmap) {
        if (val == 0) return s.IndexOf(key);
    } 
    return -1;
}
