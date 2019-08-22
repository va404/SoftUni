function solve(input) {
    let products = new Map()

    for (let line of input) {
        let [product, price] = line.split(' : ')
        let firstLetter = product[0].toUpperCase()
        if (!products.has(firstLetter)) {
            products.set(firstLetter, new Map())
        }
        products.get(firstLetter).set(product, Number(price))
    }
    let keys = Array.from(products.keys()).sort()

    for(let letter of keys) {
        console.log(letter);
        let secondMap = Array.from(products.get(letter).keys()).sort()
        for (let prod of secondMap) {
            console.log(`  ${prod}: ${products.get(letter).get(prod)}`)
        }
    }
}
