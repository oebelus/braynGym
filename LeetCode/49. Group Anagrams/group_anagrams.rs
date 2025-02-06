use std::collections::HashMap;

// Naive solution.
pub fn group_anagrams_naive(strs: Vec<String>) -> Vec<Vec<String>> {
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


// Solution using an array of size O(26) to index the HashMap of groups of anagrams. 
fn group_anagrams(strs: Vec<String>) -> Vec<Vec<String>> {
    let mut result: HashMap<String, Vec<String>> = Default::default();

    for s in strs {
        let mut count = [0; 26];

        for c in s.chars() {
            count[(c as u8 - b'a') as usize] += 1;
        }

        let key = count
            .iter()
            .map(|&x| x.to_string())
            .collect::<Vec<String>>()
            .join(",");

        result.entry(key).or_insert(Vec::new()).push(s);
    }

    return result.into_values().collect();
}
