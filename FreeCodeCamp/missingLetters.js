function fearNotLetter(str) {

  let alphabet = 'abcdefghijklmnopqrstuvwxyz'

  let newAlpha = alphabet.indexOf(str[0])

  for (let i = 0; i < str.length; i++) {

    if (str[i] !== alphabet[newAlpha + i]) {
      return alphabet[newAlpha + i]
    }

  }
  
}

// Find the missing letter in the passed letter range and return it. If all letters are present in the range, return undefined.

