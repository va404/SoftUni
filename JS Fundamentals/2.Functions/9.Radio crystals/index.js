function solve(input) {
    let target = input[0]

    cut = (num) => num / 4
    lap = (num) => num * 0.8

    grind = (num) => num - 20

    etch = (num) => num - 2

    transportAndWash = (num) => {
        console.log('Transporting and washing');
        return Math.floor(num)
    }
    xRay = (num) => {
        console.log('X-ray x1')
        return ++num
    }
    for (let i = 1; i < input.length; i++) {
        let microns = input[i]
        console.log(`Processing chunk ${microns} microns`);

        microns = executeOperation(target, microns, 'Cut', cut)
        microns = executeOperation(target, microns, 'Lap', lap)
        microns = executeOperation(target, microns, 'Grind', grind)
        microns = executeOperation(target, microns, 'Etch', etch)

        if (microns + 1 == target) {
            microns = xRay(microns)
        }
        console.log(`Finished crystal ${microns} microns`);
    }

    function executeOperation(target, size, operationName, operation) {
        let counter = 0

        while (operation(size) >= target || size - target === 1) {
            size = operation(size)
            counter++
        }
        if (counter > 0) {
            console.log(`${operationName} x${counter}`);
            size = transportAndWash(size)
        }
        return size
    }
}

