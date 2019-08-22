(() => {
    let counter = 0
    return class Extensilbe {
        constructor() {
            this.id = counter
            counter++
        }

        extend(template) {
            for (let prop of Object.keys(template)) {
                if (typeof(template[prop]) == "function") {
                    Object.getPrototypeOf(this)[prop] = template[prop]
                } else {
                    this[prop] = template[prop]
                }
            }
        }
    }
})()