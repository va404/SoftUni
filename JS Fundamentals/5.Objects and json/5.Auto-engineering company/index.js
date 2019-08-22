function solve(input) {
    let data = new Map()

    for (let line of input) {
        let [carBrand, carModel, producedCars] = line.split(' | ')
        producedCars = Number(producedCars)

        if (!data.has(carBrand)) {
            data.set(carBrand, new Map)
        }

        if (!data.get(carBrand).has(carModel)) {
            data.get(carBrand).set(carModel, 0)
        }

        data.get(carBrand).set(carModel, data.get(carBrand).get(carModel) + producedCars)
    }

    for (let [brand, secodMap] of data) {
        console.log(brand);
        for (let [models, count] of secodMap) {
            console.log(`###${models} -> ${count}`);
            
        }
        
    }
}

