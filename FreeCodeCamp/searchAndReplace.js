function myReplace(str, before, after) {
  let newArr = str.split(' ')

  for (let i = 0; i < newArr.length; i++) {

    if (newArr[i] == before) {

      if (before[0].toUpperCase() === before[0]) {
        after = after.slice(0, 1).toUpperCase() + after.slice(1)
      }
      else if (after[0].toUpperCase() === after[0]) {
        after = after.slice(0, 1).toLowerCase() + after.slice(1)
      }
      newArr[i] = newArr[i].replace(before, after)
      return newArr.join(' ')
    }

  }
  
}

/* 

Perform a search and replace on the sentence using the arguments provided and return the new sentence.

First argument is the sentence to perform the search and replace on.

Second argument is the word that you will be replacing (before).

Third argument is what you will be replacing the second argument with (after).

Note: Preserve the case of the first character in the original word when you are replacing it. For example if you mean to replace the word Book with the word dog, it should be replaced as Dog

*/
