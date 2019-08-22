function argumentInfo() {
    let countsObj = {}

    for (let arg of arguments) {
        console.log(`${typeof(arg)}: ${arg}`)
        if (!countsObj[typeof(arg)]) {
            countsObj[typeof(arg)] = 1
        }
        else {
            countsObj[typeof(arg)]++
        }
    }
   Object.keys(countsObj).sort((a,b)=> countsObj[b]-countsObj[a]).forEach(el => console.log(`${el} = ${countsObj[el]}`))
}

argumentInfo()