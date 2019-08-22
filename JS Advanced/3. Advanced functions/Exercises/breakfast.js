let result = (() => {
    let ingredients = {}

    ingredients['protein'] = 0
    ingredients['carbohydrate'] = 0
    ingredients['fat'] = 0
    ingredients['flavour'] = 0

    function restock([ingredient, quantity]) {
        quantity = Number(quantity)
        ingredients[ingredient] += quantity
        return 'Success'
    }

    function prepare([recipe, quantity]) {
        quantity = Number(quantity)
        let message = ''
        switch (recipe) {
            case 'apple':
                if (ingredients['flavour'] < quantity * 2) {
                    message = 'Error: not enough flavour in stock'
                }
                if (ingredients['carbohydrate'] < quantity) {
                    message = 'Error: not enough carbohydrate in stock'
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 2
                    ingredients['carbohydrate'] -= quantity
                    return 'Success'
                }
                return message
                break
            case 'burger':
                if (ingredients['flavour'] < quantity * 3) {
                    message = 'Error: not enough flavour in stock'
                }
                if (ingredients['fat'] < quantity * 7) {
                    message = 'Error: not enough fat in stock'
                }
                if (ingredients['carbohydrate'] < quantity * 5) {
                    message = 'Error: not enough carbohydrate in stock'
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 3
                    ingredients['carbohydrate'] -= quantity * 5
                    ingredients['fat'] -= quantity * 7
                    return 'Success'
                }
                return message
                break
            case 'coke':
                if (ingredients['flavour'] < quantity * 20) {
                    message = 'Error: not enough flavour in stock'
                }
                if (ingredients['carbohydrate'] < quantity * 10) {
                    message = 'Error: not enough carbohydrate in stock'
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 20
                    ingredients['carbohydrate'] -= quantity * 10
                    return 'Success'
                }
                return message
                break
            case 'omelet':
                if (ingredients['flavour'] < quantity) {
                    message = 'Error: not enough flavour in stock'
                }
                if (ingredients['fat'] < quantity) {
                    message = 'Error: not enough fat in stock'
                }
                if (ingredients['protein'] < quantity * 5) {
                    message = 'Error: not enough protein in stock'
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity
                    ingredients['protein'] -= quantity * 5
                    ingredients['fat'] -= quantity
                    return 'Success'
                }
                return message
                break
            case 'cheverme':
                if (ingredients['flavour'] < quantity * 10) {
                    message = 'Error: not enough flavour in stock'
                }
                if (ingredients['fat'] < quantity * 10) {
                    message = 'Error: not enough fat in stock'
                }
                if (ingredients['protein'] < quantity * 10) {
                    message = 'Error: not enough protein in stock'
                }
                if (ingredients['carbohydrate'] < quantity * 10) {
                    message = 'Error: not enough carbohydrate in stock'
                }
                if (message == '') {
                    ingredients['flavour'] -= quantity * 10
                    ingredients['protein'] -= quantity * 10
                    ingredients['fat'] -= quantity * 10
                    ingredients['carbohydrate'] -= quantity * 10
                    return 'Success'
                }
                return message
                break
        }
    }

    function report() {
        return `protein=${ingredients['protein']} carbohydrate=${ingredients['carbohydrate']} fat=${ingredients['fat']} flavour=${ingredients['flavour']}`
    }

    return function (cmd) {
        let tokens = cmd.split(' ')

        let action = tokens.shift()
        switch (action) {
            case 'prepare':
                return prepare(tokens)
                break
            case 'restock':
                return restock(tokens)

            case 'report':
                return report()
                break
        }
    }
})()




/*console.log(robot('restock carbohydrate 10'));
console.log(robot('restock flavour 10'));
console.log(robot('prepare apple 1'));
console.log(robot('restock fat 10'));
console.log(robot('prepare burger 1'));
console.log(robot('report'));*/



console.log(result("prepare cheverme 1"));
console.log(result("restock protein 10"));
console.log(result("prepare cheverme 1"));
console.log(result("restock carbohydrate 10"));
console.log(result("prepare cheverme 1"));
console.log(result("restock fat 10"));
console.log(result("prepare cheverme 1"));
console.log(result("restock flavour 10"));
console.log(result("prepare cheverme 1"));
console.log(result("report"));
