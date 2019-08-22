function solve(input) {

    let initialSum = input[0].reduce((a, b)  => a + b, 0)
    

    for(let i = 0; i < input.length; i++) {
        let sumRow = input[i].reduce((a, b) => a + b, 0)
        if (sumRow != initialSum) {
            return false
        }
      
    }
    for (let i = 0; i < input[0].length; i++) {
        let sumCol = 0
        for (let j = 0; j < input.length; j++) {
            sumCol += input[i][j]
        }
        if (sumCol != initialSum) {
            return false
        }
    }
    return true
    
    
}
