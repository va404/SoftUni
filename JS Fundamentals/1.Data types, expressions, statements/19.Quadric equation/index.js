function solve(a, b, c) {
    let d = Math.pow(b, 2) - 4 * a * c
    let x = 0
    let x1 = 0
    if (d > 0) {
        x = -(Math.sqrt(d) + b) / (2 * a)
        x1 = (Math.sqrt(d) - b) / (2 * a)

        console.log(Math.min(x, x1))
        console.log(Math.max(x, x1))

    } else if (d == 0) {
        x = -b / (2 * a)
        console.log(x);
        
    } else {
        console.log('No');
        
    }
}
