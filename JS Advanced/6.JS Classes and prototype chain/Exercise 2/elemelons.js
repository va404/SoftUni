function solve() {
    class Melon {
        constructor(weight, melonSort) {
            if (new.target === Melon) {
                throw new TypeError('Cannot be instantiated directly')
            }
            this.weight = weight
            this.melonSort = melonSort
            this._elementIndex = this.weight * this.melonSort.length
            this.element = ''
        }

        get elementIndex() {
            return this._elementIndex
        }

        toString() {
            return `Element: ${this.element}\nSort: ${this.melonSort}\nElement Index: ${this.elementIndex}`
        }
    }

    class Watermelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Water'
        }
    }

    class Firemelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Fire'
        }
    }

    class Earthmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Earth'
        }
    }

    class Airmelon extends Melon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Air'
        }
    }

    class Melolemonmelon extends Watermelon {
        constructor(weight, melonSort) {
            super(weight, melonSort)
            this.element = 'Water'
            this.elements = ['Fire', 'Earth', 'Air', 'Water']
            this.eIndex = 0
        }

        morph() {
            this.element = this.elements[this.eIndex++ % 4]
        }
    }
    return {
        Melon,
        Earthmelon,
        Firemelon,
        Airmelon,
        Watermelon,
        Melolemonmelon
    }
}