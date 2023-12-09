function fibonacci(n) {
  let arr = [0, 1];
  let i = 1;
  while (arr[i] + arr[i - 1] <= n)
  {
    arr.push(arr[i] + arr[i-1]);
    i += 1;
  }
  return arr;
}

function fiboEvenSum(n) {
  let arr = fibonacci(n);
  let evenArr = [];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 == 0) {
      evenArr.push(arr[i])
    }
  }
  console.log(evenArr)
  return evenArr.reduce(function (a, b) {return a + b})
}

console.log(fiboEvenSum(8))
