fn lonelyinteger(a: &[i32]) -> i32 {
    let mut x = 0;
    
    for n in a {
        x = n ^ x;
    }
    
    x
}

fn lonelyinteger1(a: &[i32]) -> i32 {
    a.iter().fold(0, |x, n| x ^ n)
}
