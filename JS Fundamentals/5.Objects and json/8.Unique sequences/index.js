function solve(input) {
    let data = new Map()
    for (let line of input) {
        let sequence = JSON.parse(line).map(Number)
        sequence.sort((a, b) => b - a)
        let length = sequence.length
        if (!data.has(length)) {
            data.set(length, new Set())
        }
        data.get(length).add(`[${sequence.join(', ')}]`)
    }
    let sortedLength = Array.from(data.keys()).sort((a, b) => a - b)
    for (let length of sortedLength) {
        for (let seq of data.get(length)) {
            console.log(seq)
        }
    }
}