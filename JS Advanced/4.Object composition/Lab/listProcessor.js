function solve(cmd) {
    let processor = (function () {
        let list = []
        return {
            add: newItem => list.push(newItem),
            remove: item => list = list.filter(el => el != item),
            print: () => console.log(list.join(','))
        }
    })()
    for(let line of cmd) {
        [cmdName, argument ] = line.split(' ')
        processor[cmdName](argument)
    }
}
solve(['add hello', 'add again', 'remove hello', 'add again', 'print'])