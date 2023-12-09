def isomorphic_strings(s, t):
    strings = dict()
    length = len(s)
    for i in range(length):
        if s[i] in strings and strings[s[i]] != t[i]:
            return False
        elif t[i] in strings.values() and s[i] not in strings:
            return False
        else:
            strings[s[i]] = t[i]
    return True;
    
s = "egeg"
t = "adzd"
print(isomorphic_strings(s, t))

def isomorphic_strings_1(s, t):
    sdict = dict()
    tdict = dict()
    length = len(s)
    for i in range(length):
        if s[i] not in sdict:
            sdict[s[i]] = t[i]
        if t[i] not in tdict:
            tdict[t[i]] = s[i]
        if s[i] in sdict and sdict[s[i]] != t[i] or t[i] in tdict and tdict[t[i]] != s[i]:
            return False
    return True
