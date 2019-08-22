function solve(input) {

    let data = new Map()

    for (let line of input) {
        let [sysName, component, subComponent] = line.split(' | ')

        if (!data.has(sysName)) {
            data.set(sysName, new Map())
        }
        if (!data.get(sysName).has(component)) {
            data.get(sysName).set(component, new Set())
        }
        data.get(sysName).get(component).add(subComponent)
    }
    let sortedSys = Array.from(data.keys()).sort(function (a, b) {
        let A = Array.from(data.get(a).keys())
        let B = Array.from(data.get(b).keys())
        return A.length != B.length ? B.length - A.length : a.localeCompare(b)

    })
    for (let system of sortedSys) {
        console.log(system)
        let sortedComp = Array.from(data.get(system).keys()).sort(function (a, b) {
            let A = Array.from(data.get(system).get(a))
            let B = Array.from(data.get(system).get(b))
            return B.length - A.length
        })
        for (let component of sortedComp) {
            console.log(`|||${component}`)
            for (let subcomp of data.get(system).get(component)) {
                console.log(`||||||${subcomp}`)
            }
        }
    }

}