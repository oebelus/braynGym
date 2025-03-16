fn find_median(arr: &[i32]) -> i32 {
    let mut a = arr.to_vec();

    a.sort();

    a[a.len() / 2]
}
