function sumPrimes(num) {

let arr = []
  
  // Set a function that verifies if a number is prime
  function isPrime(x) {
    
    if (x < 2) {return false}

    for (let i = 2; i < x; i++) {
      if(x % i == 0) {
        return false
     }   
    }
    return true
  } 

let current = 2

// Make an array that contains all the numbers between 2 and 'num'
while (current <= num) {
    arr.push(current)
    current++
  }

// Filter the array as it contains only primes
let prime = arr.filter(e => isPrime(e))

// Sum all the element of 'prime' array
return prime.reduce((a, b) => a + b)

}

/* 

A prime number is a whole number greater than 1 with exactly two divisors: 1 and itself. For example, 2 is a prime number because it is only divisible by 1 and 2. In contrast, 4 is not prime since it is divisible by 1, 2 and 4.

Rewrite sumPrimes so it returns the sum of all prime numbers that are less than or equal to num.

*/
