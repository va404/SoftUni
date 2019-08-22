function solve(input) {
    let p = input[0]
    let i = input[1] / 100
    let n = 12 / input[2]
    let t = input[3]
    let result = p *  Math.pow((1+(i / n)), n*t)

    console.log(result.toFixed(2))
}
