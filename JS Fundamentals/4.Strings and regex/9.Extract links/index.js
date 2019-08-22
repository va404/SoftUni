function solve(input) {
    // let regex = /www\.[a-zA-Z0-9\-]+(\.[a-z]+)+/gm
    // let arr = input.join(' ').match(regex)
  
    // console.log(arr.join('\n'));
    let regex = /www\.[a-zA-Z0-9\-]+(\.[a-z]+)+/gm
    let match = regex.exec(input)
    for (let line of input) {
        while (match) {
            console.log(`${match[0]}`)

            match = regex.exec(input)
        }
    }
}


    