function solve(rows, cols) {
    let target = rows * cols
    let num = 1
    let matrix = fillMatrixWithZeroes(rows, cols)
    let currentRow = 0
    let currentCol = 0
    let rotations = 0

    while (target >= num) {

        for(let i = rotations; i < cols - rotations; i++ ) {
            matrix[currentRow][currentCol++] = num++
        }
        currentCol -= 1

        for(let i = ++currentRow; i <= rows - 1 - rotations; i++ ) {
            matrix[currentRow++][currentCol] = num++
        }
        currentRow -= 1
        for(let i = --currentCol; i >= rotations; i-- ) {
            matrix[currentRow][currentCol--] = num++
        }
        currentCol += 1
        for(let i = --currentRow; i > rotations; i-- ) {
            matrix[currentRow--][currentCol] = num++
        }
        rotations++
        currentRow++
        currentCol++
    }
    function fillMatrixWithZeroes(rows, cols) {
        let matrix = []

        for (let i = 0; i < rows; i++) {
            matrix.push('0'.repeat(cols).split('').map(Number))
        }
        return matrix   
    }
    console.log(matrix.map(e => e.join(' ')).join('\n'));
    
    
}


