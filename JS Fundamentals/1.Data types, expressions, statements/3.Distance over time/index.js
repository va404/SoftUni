function solve([v1, v2, time]) {

    let timeInHours = time / 60 / 60;
    let firstObjectDistance = v1 * timeInHours * 1000
    let secondObjectDistance = v2 * timeInHours * 1000

    console.log(Math.abs(firstObjectDistance - secondObjectDistance))
}

