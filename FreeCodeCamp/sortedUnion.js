function uniteUnique(arr) {
  let newArr = []
  let intArr = []
  
  // Group the arrays into one array as follows: [ [ 1, 3, 2 ], [ 5, 2, 1, 4 ], [ 2, 1 ] ]
  for (var i = 0; i < arguments.length; i++) {
    newArr.push(arguments[i])
  }

  // One array without any nested array as follows: [ '1', '3', '2', '5', '2', '1', '4', '2', '1' ], note that the elements are strings
  let separatedArgs = newArr.toString().split(',')
  
  // Convert the elements to integer, we obtain: [ 1, 3, 2, 5, 2, 1, 4, 2, 1 ]
  for (let j = 0; j < separatedArgs.length; j++) {
    intArr.push(parseInt(separatedArgs[j]))
  }

  let uniqueChars = [...new Set(intArr)];
  return uniqueChars //[ 1, 3, 2, 5, 4 ]
  
}

/*

Write a function that takes two or more arrays and returns a new array of unique values in the order of the original provided arrays.

In other words, all values present from all arrays should be included in their original order, but with no duplicates in the final array.

The unique numbers should be sorted by their original order, but the final array should not be sorted in numerical order.

Check the assertion tests for examples.

*/
