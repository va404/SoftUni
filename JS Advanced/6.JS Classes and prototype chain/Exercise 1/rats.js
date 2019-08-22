class Rat {
    constructor(name) {
        this.name = name
        this.united = []
    }
    unite (anotherRat) {
        if (anotherRat instanceof Rat){
            this.united.push(anotherRat)
        }

    }
    getRats (){
        return this.united
    }
    toString () {
        let string = `${this.name}\n`
        for(let rat of this.united){
            string += `##${rat.name}\n`
        }
        return string
    }
}

let test = new Rat('pesho')

console.log(test.getRats())