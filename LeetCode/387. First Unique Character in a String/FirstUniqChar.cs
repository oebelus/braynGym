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
