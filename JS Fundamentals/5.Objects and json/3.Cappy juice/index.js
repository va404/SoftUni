function solve(input) {
    let data  = new Map()
    let bottles = new Map()

    for (let line of input) {
        let lineData = line.split(' => ')
        let juice = lineData[0]
        let quantity = Number(lineData[1])

        if (!data.has(juice)) {
            data.set(juice, 0)
        }

        data.set(juice, data.get(juice) + quantity)
        quantity = data.get(juice)
        
        if (quantity >= 1000) {
            bottles.set(juice, Math.floor(quantity / 1000))
        }
    }
    for (let [juice, bottle] of bottles) {
        console.log(`${juice} => ${bottle}`)
    }
}

