function solve(input) {
    let num = parseInt(input[0])

    for (let i = 1; i < input.length; i++) {
        let operation = input[i]
        
        switch (operation) {
            case 'chop':
                num /= 2
                console.log(num)
                break
            case 'dice':
                num = Math.sqrt(num)
                console.log(num)
                break
            case 'spice':
                num += 1
                console.log(num)
                break
            case 'bake':
                num *= 3
                console.log(num)
                break
            case 'fillet':
                num *= 0.8
                console.log(num)
                break

        }
    }
}