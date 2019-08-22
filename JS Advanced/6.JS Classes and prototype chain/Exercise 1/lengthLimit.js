class Stringer {
    constructor(str, length) {
        this.innerString  = str
        this.innerLength = length
        this.newStr = ''
    }

    decrease(num) {
        this.innerLength -= num
        if (this.innerLength < 0) {
            this.innerLength = 0
        }

    }

    increase(num) {
        this.innerLength += num

    }

    toString() {
        if (this.innerLength == 0) {
            return '...'
        }
        if (this.innerString .length > this.innerLength) {
           this.newStr  = this.innerString .substr(0, this.innerLength) + '...'
            return this.newStr
        }
        return this.innerString
    }
}

let test = new Stringer('Test', 5)
console.log(test.toString())
test.decrease(3)
console.log(test.toString())
test.decrease(5)
console.log(test.toString())
test.increase(4)
console.log(test.toString())