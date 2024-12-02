pub fn fibonacci(n: u32) -> u32 {
    match n {
        0 => 0,
        1 => 1,
        _ => fibonacci(n - 1) + fibonacci(n - 2),
    }
}

pub struct Minutes(pub i32);
pub struct Hours(pub i32);
pub struct Days(pub i32);

impl From<Minutes> for Hours {
    fn from(minutes: Minutes) -> Hours {
        // Implement the minute to hour conversion here
        minutes * 60
    }
}

// TODO: implement from hours to days
fn from(hours: Hours) -> Days {
    // Implement the hour to day conversion here
    hours / 24
}

// TODO: implement from minutes to days
fn from(minutes: Minutes) -> Days {
    // Implement the minute to day conversion here
    minutes / 1440
}

// TODO: implement from days to hours
fn from(days: Days) -> Hours {
    // Implement the day to hour conversion here
    days * 24
}
