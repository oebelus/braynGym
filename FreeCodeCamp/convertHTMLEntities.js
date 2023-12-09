function convertHTML(str) {

  var html = {
    '&': '&amp;',
    '<': '&lt;',
    '>': '&gt;',
    '"': '&quot;',
    "'": '&apos;'
  }

  var arr = str.split('')

  //var mapArr = arr.map(elem => html[elem])

  var newStr = str.replace(/[&<>\"']/g, elem => html[elem])
  return newStr
   
}

// Convert the characters &, <, >, " (double quote), and ' (apostrophe), in a string to their corresponding HTML entities.
