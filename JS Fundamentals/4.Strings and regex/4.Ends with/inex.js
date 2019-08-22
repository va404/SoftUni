function solve(str, subStr) {
    let index = str.lastIndexOf(subStr)
   
    while(index > -1) {
        return true
    }
    return false
}

