function solve(input) {
    let num = input[0]
    let precison = input[1]

    if (precison > 15) {
        precison = 15
    }
    let multiplier = Math.pow(10, precison)
    let result = Math.round(num * multiplier) / multiplier
    console.log(result);

}
