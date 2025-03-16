fn closest_numbers(arr: &[i32]) -> Vec<i32> {
    let mut a = arr.to_vec();

    a.sort();

    let mut ans = Vec::new();
    let mut low = a[1] - a[0];

    // w is a slice (&[i32])
    for w in a.windows(2) {
        let diff = w[1] - w[0];

        match diff {
            x if x < low => {
                low = x;
                ans.clear();
                ans.extend_from_slice(w);
            }
            x if x == low => ans.extend_from_slice(w),
            _ => {}
        }
    }

    ans
}
