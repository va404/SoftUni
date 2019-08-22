function solve(input) {
    let pow = input.power
    let carPower, carVolume = 0
    if (pow <= 90) {
        carPower = 90
        carVolume = 1800
    } else if (pow <= 120) {
        carPower = 120
        carVolume = 2400
    } else if (pow <= 200) {
        carPower = 200
        carVolume = 3500
    }

    let obj = {
        model: `${input.model}`,
        engine: {
            power: carPower,
            volume: carVolume
        },
        carriage: {
            type: input.carriage,
            color: input.color
        },
        wheels: input.wheelsize % 2 === 0 ? [input.wheelsize - 1, input.wheelsize - 1, input.wheelsize - 1, input.wheelsize - 1] :
            [input.wheelsize, input.wheelsize, input.wheelsize, input.wheelsize,]
    }
    return obj

}

console.log(solve({ model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14 }

))