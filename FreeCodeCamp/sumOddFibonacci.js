// This is a stupid answer by the way xDDD

function sumFibs(num) {
  
  // First three elements of the Fibonacci sequence (To make things easy)
  var fibonacci = [1, 1, 2]
  
  // Continue Fibonacci sequence if the 'num' is greater the last element of the array 'fibonacci' which is 2
  for (let i = 0; i < fibonacci.length; i++) {
    if (num > fibonacci[fibonacci.length - 1]) {
      fibonacci.push(fibonacci[fibonacci.length - 1] + fibonacci[fibonacci.length - 2])
  }
}

  // Remove elements greater than 'num'
  const fib = fibonacci.filter(number => number <= num)
  
  // Select the odd elements
  const odd = fib.filter(number => number % 2 == 1)
  
  // Sum them
  const plus = odd.reduce((a, b) => a + b, 0)

  return plus 
}

/*

Given a positive integer num, return the sum of all odd Fibonacci numbers that are less than or equal to num.

The first two numbers in the Fibonacci sequence are 1 and 1. Every additional number in the sequence is the sum of the two previous numbers. The first six numbers of the Fibonacci sequence are 1, 1, 2, 3, 5 and 8.

For example, sumFibs(10) should return 10 because all odd Fibonacci numbers less than or equal to 10 are 1, 1, 3, and 5.

*/
