use std::fs::File;
use std::io;
use std::io::BufRead;
use std::io::BufReader;

fn absolute(a: i32) -> i32 {
    if a < 0 {
        a * -1
    } else {
        a
    }
}

fn main() -> io::Result<()> {
    let mut list_1: Vec<u32> = Vec::new();
    let mut list_2: Vec<u32> = Vec::new();

    let f = File::open("numbers.txt")?;

    for line in BufReader::new(f).lines() {
        match line {
            Ok(s) => {
                let parts: Vec<&str> = s.split_whitespace().collect();
                match (parts[0].parse::<u32>(), parts[1].parse::<u32>()) {
                    (Ok(a), Ok(b)) => {
                        list_1.push(a);
                        list_2.push(b);
                    }
                    (Err(e), _) | (_, Err(e)) => {
                        println!("Error: {}", e);
                    }
                }
            }
            Err(e) => {
                println!("Error: {}", e);
            }
        }
    }

    list_1.sort();
    list_2.sort();

    let length = list_1.len();
    let mut distance = 0;

    for i in 0..length {
        distance += absolute(list_1[i] as i32 - list_2[i] as i32);
    }

    let mut similarity = 0;

    for i in 0..length {
        let val = list_2[i];
        let mut count = 0;

        for j in 0..length {
            if list_1[j] == val {
                count += 1;
            }
        }

        similarity += count * val;
    }

    println!("{}", distance);
    println!("{}", similarity);

    Ok(())
}
