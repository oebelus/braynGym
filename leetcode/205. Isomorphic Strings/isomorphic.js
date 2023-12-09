const checkIsomorphic = function(s,t){
    var dict = new Object({})
    length = s.length
    for (let i = 0; i < length; i++) {
        if (s[i] in dict && dict[s[i]] !== t[i])
            return false
        else if (Object.values(dict).indexOf(t[i]) != -1 && !(s[i] in dict))
            return false
        else
            dict[s[i]] = t[i]
    }
    return true
}

const checkIsomorphic_2 = function(s,t){
    var sdict = new Object({})
    var tdict = new Object({})
    length = s.length
    for (let i = 0; i < length; i++) {
        if (!(s[i] in sdict))
            sdict[s[i]] = t[i]
        if (!(t[i] in tdict))
            tdict[t[i]] = s[i]
        if (sdict[s[i]] != t[i] || tdict[t[i]] != s[i])
            return false
    }
    return true
}
