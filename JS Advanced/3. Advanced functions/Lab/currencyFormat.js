function currencyFormatter(separator, symbol, symbolFirst, value) {
    let result = Math.trunc(value) + separator;
    result += value.toFixed(2).substr(-2, 2);
    if (symbolFirst) return symbol + ' ' + result;
    else return result + ' ' + symbol;
}

let formatter = getDollarFormatter(currencyFormatter)

function getDollarFormatter(formatter) {
    return function (value) {
        return formatter(',', '$', true, value)
    }
}


console.log(formatter(50.2135321));