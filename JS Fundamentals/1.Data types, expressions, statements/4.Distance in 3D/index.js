function solve([x1, y1, z1, x2, y2, z2]) {
   let deltaX = x1-x2
   let deltaY = y1-y2
   let deltaZ = z1-z2

    let result = deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ
   
    console.log(Math.sqrt(result))
}
