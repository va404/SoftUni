(function solve() {
    String.prototype.ensureStart = function (str) {
        if (!this.toString().startsWith(str)) {
            return str + this.toString()
        } else {
            return this.toString()
        }
    }
    String.prototype.ensureEnd = function (str) {
        if (!this.toString().endsWith(str)) {
            return this.toString() + str
        } else {
            return this.toString()
        }
    }
    String.prototype.isEmpty = function () {
        return this.toString() == ''
    }
    String.prototype.truncate = function (n) {
        if (n <= 3) {
            return '.'.repeat(n)
        }
        if (this.toString().length <= n) {
            return this.toString()
        } else {
            let lastIndex = this.toString().substr(0, n - 2).lastIndexOf(' ')
            if (lastIndex != -1) {
                return this.toString().substr(0, lastIndex) + '...'
            } else {
                return this.toString().substr(0, n - 3) + '...'
            }
        }

    }
    String.format = function (str, ...params) {
        for (let i = 0; i < params.length; i++) {
            let index = str.indexOf('{' + i + '}')
            while (index != -1) {
                str = str.replace('{' + i + '}', params[i])
                index = str.indexOf('{' + i + '}')
            }
        }
        return str
    }
})()

let str = 'quick brown fox jumps over the lazy dog'
console.log(str = str.ensureStart('the '))
