fn balancedSums(arr: &[i32]) -> String {
    if arr.len() < 2 {
        "YES".into()
    } else {
        let length = arr.len();

        for i in 0..length {
            let a = &arr[0..i];
            let b = &arr[(i + 1)..arr.len()];

            if a.iter().sum::<i32>() == b.iter().sum::<i32>() {
                return "YES".into();
            }
        }

        "NO".into()
    }
}
