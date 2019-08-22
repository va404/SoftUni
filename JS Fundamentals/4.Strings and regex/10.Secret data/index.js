function solve(input) {
    let regexName = /\*[A-Z]{1}[a-zA-Z]*(?= |\t|$)/g
    let regexPhoneNumber = /\+[0-9\-]{10}(?=\t| |$)/g
    let regexId = /![a-zA-Z0-9]+(?=\t| |$)/g
    let regexBase = /_[a-zA-Z0-9]+(?=\t| |$)/g

    for (let line of input) {
        line = line.replace(regexName, w => '|'.repeat(w.length))
        line = line.replace(regexId, w => '|'.repeat(w.length))
        line = line.replace(regexPhoneNumber, w => '|'.repeat(w.length))
        line = line.replace(regexBase, w => '|'.repeat(w.length))

            console.log(line)
        }

}
