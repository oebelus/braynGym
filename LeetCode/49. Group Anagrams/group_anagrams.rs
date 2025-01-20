use std::collections::HashMap;

pub fn group_anagrams(strs: Vec<String>) -> Vec<Vec<String>> {
    let mut groups = HashMap::<String, Vec<String>>::new();

    for s in strs {
        let mut sorted: Vec<char> = s.chars().collect();

        sorted.sort();

        let str = sorted.iter().collect::<String>();

        if groups.contains_key(&str) {
            groups.get_mut(&str).unwrap().push(s);
        } else {
            groups.insert(str, vec![s]);
        }
    }

    groups.into_values().collect()
}
