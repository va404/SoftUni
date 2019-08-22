function solve(input) {

    if (input.handsShaking) {
        input.bloodAlcoholLevel += input.weight * input.experience * 0.1
        input.handsShaking = false
        return input
    }
    else {
        return input
    }

}

console.log(solve({ weight: 120,
    experience: 20,
    bloodAlcoholLevel: 200,
    handsShaking: true }

));