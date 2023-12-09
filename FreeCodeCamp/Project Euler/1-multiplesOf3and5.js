function multiplesOf3and5(number) {
  let arr = [];
  
  for (let i = 0; i < number; i++) {
    if (i % 3 == 0 || i % 5 == 0) {
      arr.push(i)
    }
  }
  let sum = arr.reduce(function (a,b) {return a + b})
  return (sum)
}
