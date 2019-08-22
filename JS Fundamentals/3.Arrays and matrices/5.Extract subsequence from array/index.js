function solve(input) {
    let currentBiggest = input[0]
    let resultArray = []
    for (let i = 0; i < input.length; i++) {
        if (input[i] >= currentBiggest) {
           resultArray.push(input[i])
           currentBiggest = input[i]
        } 
    }
    console.log(resultArray.join('\n'))
    
}

