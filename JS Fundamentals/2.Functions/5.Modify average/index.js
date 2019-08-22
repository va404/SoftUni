function solve(input) {
    let numString = input.toString()

    getAverage = () => {
        let sum = 0
        for (let i = 0; i < numString.length; i++) {
            sum += Number(numString[i])
        }
        return sum / numString.length
    }
    while (getAverage(numString) <= 5) {
        numString += '9'
    }
    console.log(numString);
    
}
