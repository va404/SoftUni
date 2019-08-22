function solve(str, word) {
    // let regexp = new RegExp("\\b"+word+"\\b", "gim")
    // let arr = str.split(' ').join(' ').match(regexp)
    // console.log(arr.length);

    let counter = 0
    let regex = new RegExp("\\b"+word+"\\b", "gi")
    let matches = regex.exec(str)


     while (matches) {

        counter++
         matches = regex.exec(str)
     }
     return counter
}

