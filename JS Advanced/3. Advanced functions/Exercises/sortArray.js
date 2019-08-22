function sort(inputArr, sortMethod) {
    /*
        if (sortMethod === 'asc') {
            return inputArr.sort((a, b) => a - b)
        }
        else {
            return inputArr.sort((a, b) => b - a)
        }*/
    let ascendingComaprator = function (a, b) {
        return a - b
    }
    let descendingComaprator = function (a, b) {
        return  b - a
    }
    let sortObj = {
        'asc': ascendingComaprator,
        'desc': descendingComaprator

    }
    return inputArr.sort(sortObj[sortMethod])
}

console.log(sort([14, 7, 17, 6, 8], 'asc'));