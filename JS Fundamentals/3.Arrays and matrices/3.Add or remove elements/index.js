function solve(input) {
    let initial = 1
    let result = []

    for (let i = 0; i < input.length; i++) {
        if (input[i] === 'add') {
            result.push(initial)
            initial++
        } else {
            result.pop()
            initial++
        }
    }
    return result.length > 0 ? console.log(result.join('\n')) : console.log('Empty');    
}

