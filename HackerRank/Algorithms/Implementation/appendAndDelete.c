int length(char* s) {
    int count = 0;
    while (s[count]) {
        count++;
    }
    return count;
}

char* appendAndDelete(char* s, char* t, int k) {
    int lengthS = length(s);
    int lengthT = length(t);
    int count = 0;
    int passed = 0;
    if (lengthS > lengthT) {
        count += lengthS - lengthT;
        for (int i = 0; i < lengthS; i++) {
            if (s[i] != t[i]) {
                count += lengthT - i;
            }
        }
    } else if (lengthS == lengthT) {
        int i = 0;
        while (s[i] && s[i] == t[i]) {
            count++;
            i++;
        }
        if (count == lengthS) count = k;
        else count = k >= lengthS + lengthT ? k : lengthS + lengthT;
    } else {
        count += lengthT - lengthS;
        if (s[lengthS-1] == t[lengthT-1]) count = k;
        else count = k + 1;
    }
    if (count <= k && count != 0) return "Yes";
    else return "No";
}
