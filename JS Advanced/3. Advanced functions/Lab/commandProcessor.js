function commandProcessor(arr) {
    let closure = (function () {
        let str = ''
        return {
            append: (s) => str += s,
            removeStart: (n) => str = str.substring(n),
            removeEnd: (n) => str = str.substring(0, str.length - n),
            print: () => console.log(str)
        }
    })()
    for(let line of arr) {
        let [cmd, value] = line.split(' ')
        closure[cmd](value)
    }
}
commandProcessor(['append hello',
    'append again',
    'removeStart 3',
    'removeEnd 4',
    'print']
)