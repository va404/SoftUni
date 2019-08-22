function solve(input) {
    let x0 = 0
    let y0 = 0

    function calculateDistance(x1, y1, x2, y2) {
        let distanceX = Math.abs(x1 - x2)
        let distanceY = Math.abs(y1 - y2)
        let result = Math.sqrt(distanceX * distanceX + distanceY * distanceY)
        return result
    }

    let [x1, y1, x2, y2] = input
    let firstDistance = calculateDistance(x1, y1, x0, y0)
    let secondDistance = calculateDistance(x2, y2, x0, y0)
    let thirdtDistance = calculateDistance(x1, y1, x2, y2)

    console.log(`\{${x1}, ${y1}\} to {0, 0} is ${firstDistance % 1 !== 0 ? 'invalid' : 'valid'}`)
    console.log(`\{${x2}, ${y2}\} to {0, 0} is ${secondDistance % 1 !== 0 ? 'invalid' : 'valid'}`)
    console.log(`\{${x1}, ${y1}\} to \{${x2}, ${y2}\} is ${thirdtDistance % 1 !== 0 ? 'invalid' : 'valid'}`)
}
