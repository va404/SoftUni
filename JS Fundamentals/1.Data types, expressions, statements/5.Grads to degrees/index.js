function solve(grads) {
    
    grads = grads % 400
    let degrees = grads * 0.9

    let output = degrees < 0 ? 360 + degrees : degrees
    console.log(output)
}

