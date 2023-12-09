function rot13(str) {
  let alp = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
  let newArr = ""
  let arr = []
  
  for (let i = 0; i < str.length; i++) {
    if (str[i].match(/[A-Z]/g) != null) {
      let a = alp.indexOf(str[i]) + 13
      if (a >= alp.length) {
        a -= alp.length
        arr.push(a)
      } else {
        arr.push(a)
      } 
     } 
     else {
       arr.push(str[i])
    } 
  }
  for (let j = 0; j < str.length; j++) {
    if (str[j].match(/[A-Z]/g) != null) {
      let b = alp[arr[j]]
      newArr += b
    } else {
      newArr += str[j]
    }
    
     }
  
   return newArr
}
