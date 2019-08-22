function solve(input) {
    let matrix = input.map(e => e.split(' ').map(Number))

    let [mainSum, secondarySum] = getDiagonalSum(matrix)

    if (mainSum === secondarySum) {
        for(let i = 0; i < matrix.length; i++) {
            for( let j = 0; j < matrix[i].length; j++) {
                if (i != j && j != matrix[i].length - 1 - i) {
                    matrix[i][j] = mainSum
                }
            }
        }
    }
    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
        
    }

    function getDiagonalSum(matrix) {
        let mainSum = 0
        let secondarySum = 0
        for (let i = 0; i < matrix.length; i++) {
            mainSum += matrix[i][i]
            secondarySum += matrix[i][matrix[i].length - 1 - i]
        }
        return [mainSum, secondarySum]
    }
}

