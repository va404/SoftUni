function solve(input) {
    let dnaTypes = ['AT', 'CG', 'TT', 'AG', 'GG']
    let dnaPrint = {
        0: x=> console.log(`**${x}**`),
        1: x=> console.log(`*${x[0]}--${x[1]}*`),
        2: x=> console.log(`${x[0]}----${x[1]}`)
    }
    for (let i = 0; i < input; i++) {
        let operationId = i % 4
        let index = i % dnaTypes.length
        let sequence = dnaTypes[index]
        operationId = operationId == 3 ? 1 : operationId
        dnaPrint[operationId](sequence)
    }
}

