function solve(input) {
    let rotationCounts = Number(input.pop())

    for (let i = 0; i < rotationCounts % input.length; i++) {
        let first = input.pop()
        input.unshift(first)
    }
    console.log(input.join(' ')); 
}
